/*
 * ii's Stupid Menu  Menu/UI.cs
 * A mod menu for Gorilla Tag with over 1000+ mods
 *
 * Copyright (C) 2026  Goldentrophy Software
 * https://github.com/iiDk-the-actual/iis.Stupid.Menu
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

using BepInEx;
using GorillaNetworking;
using iiMenu.Classes.Menu;
using iiMenu.Extensions;
using iiMenu.Managers;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR;
using static iiMenu.Menu.Main;
using static iiMenu.Utilities.AssetUtilities;

namespace iiMenu.Menu
{
    public class UI : MonoBehaviour
    {
        // TODO: Convert this class to the assetbundle during TMPro migration
        public static UI Instance;
        public static Texture2D watermarkImage;
        private static Sprite roundedControlBackgroundSprite;

        private void Awake()
        {
            Instance = this;

            if (File.Exists(hideGUIPath))
                isOpen = false;

            uiPrefab = LoadObject<GameObject>("UI");

            Transform canvas = uiPrefab.transform.Find("Canvas");
            watermark = canvas.Find("Watermark").GetComponent<Image>();
            versionLabel = canvas.Find("VersionLabel").GetComponent<TextMeshProUGUI>();
            roomStatus = canvas.Find("RoomStatus").GetComponent<TextMeshProUGUI>();
            arraylist = canvas.Find("Arraylist").GetComponent<TextMeshProUGUI>();
            controlBackground = canvas.Find("ControlUI").GetComponent<Image>();
            if (controlBackground != null)
            {
                controlBackground.sprite = GetRoundedControlBackgroundSprite();
                controlBackground.type = Image.Type.Sliced;
            }
            EnsurePcUiInput(canvas);
            CreatePcMenuBackground(canvas);

            debugUI = canvas.Find("DebugUI")?.gameObject;
            debugUI.AddComponent<UIDragWindow>();

            templateLine = debugUI.transform.Find("Lines/Line")?.gameObject;

            r = canvas.Find("ControlUI/R").GetComponent<TMP_InputField>();
            g = canvas.Find("ControlUI/G").GetComponent<TMP_InputField>();
            b = canvas.Find("ControlUI/B").GetComponent<TMP_InputField>();
            textInput = canvas.Find("ControlUI/TextInput").GetComponent<TMP_InputField>();
            LogManager.Log(canvas.Find("ControlUI/QueueButton"));
            canvas.Find("ControlUI/QueueButton").GetComponent<Button>().onClick.AddListener(() =>
            {
                Mods.Important.QueueRoom(textInput.text);
            });

            canvas.Find("ControlUI/JoinButton").GetComponent<Button>().onClick.AddListener(() =>
            {
                PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(textInput.text, JoinType.Solo);
            });

            canvas.Find("ControlUI/ColorButton").GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeColor(new Color32(byte.Parse(r.text), byte.Parse(g.text), byte.Parse(b.text), 255));
            });

            canvas.Find("ControlUI/NameButton").GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeName(textInput.text);
            });

            TMP_InputField inputField = debugUI.transform.Find("TextInput").gameObject.GetComponent<TMP_InputField>();

            inputField.onSelect.AddListener(_ => focusedOnDebug = true);
            inputField.onDeselect.AddListener(_ => focusedOnDebug = false);

            inputField.onEndEdit.AddListener((string text) =>
            {
                if (focusedOnDebug && !inputField.text.IsNullOrEmpty())
                    HandleDebugCommand(text);

                inputField.text = string.Empty;
            });

            textObjects = new List<TextMeshProUGUI>
            {
                canvas.Find("ControlUI/TextInput/Text Area/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/R/Text Area/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/G/Text Area/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/B/Text Area/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/QueueButton/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/JoinButton/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/ColorButton/Text").GetComponent<TextMeshProUGUI>(),
                canvas.Find("ControlUI/NameButton/Text").GetComponent<TextMeshProUGUI>()
            };

            imageObjects = new List<Image>
            {
                canvas.Find("ControlUI/TextInput").GetComponent<Image>(),
                canvas.Find("ControlUI/R").GetComponent<Image>(),
                canvas.Find("ControlUI/G").GetComponent<Image>(),
                canvas.Find("ControlUI/B").GetComponent<Image>(),
                canvas.Find("ControlUI/QueueButton").GetComponent<Image>(),
                canvas.Find("ControlUI/JoinButton").GetComponent<Image>(),
                canvas.Find("ControlUI/ColorButton").GetComponent<Image>(),
                canvas.Find("ControlUI/NameButton").GetComponent<Image>(),
                debugUI.transform.Find("TextInput").GetComponent<Image>(),
                debugUI.transform.Find("Lines").GetComponent<Image>()
            };

            watermark.material = new Material(watermark.material);
            watermarkImage = LoadTextureFromResource($"{PluginInfo.ClientResourcePath}.icon.png");

            if (!Plugin.FirstLaunch)
            {
                GameObject closeMessage = uiPrefab.transform.Find("Canvas")?.Find("HideMessage")?.gameObject;
                closeMessage?.SetActive(false);
            }

            Update();
        }

        private bool isOpen = true;
        private bool focusedOnDebug;

        private GameObject uiPrefab;
        private GameObject debugUI;

        private Image watermark;
        private TextMeshProUGUI versionLabel;
        private TextMeshProUGUI roomStatus;
        private TextMeshProUGUI arraylist;

        private TMP_InputField r;
        private TMP_InputField g;
        private TMP_InputField b;
        private TMP_InputField textInput;

        private Image controlBackground;
        private Image pcMenuBackground;
        private RectTransform pcMenuBackgroundRect;
        private GameObject pcCategorySidebar;
        private TextMeshProUGUI pcTimeLabel;
        private TextMeshProUGUI pcDateLabel;
        private TextMeshProUGUI pcMenuNameLabel;
        private Button pcSettingsButton;
        private Image pcSettingsButtonImage;
        private TextMeshProUGUI pcSettingsButtonLabel;
        private Button pcMinimizeButton;
        private Image pcMinimizeButtonImage;
        private TextMeshProUGUI pcMinimizeButtonLabel;
        private Button pcMenuNotchButton;
        private Image pcMenuNotchImage;
        private TextMeshProUGUI pcMenuNotchLabel;
        private RectTransform pcMenuNotchRect;
        private CanvasGroup pcMenuNotchCanvasGroup;
        private bool pcMenuMinimized;
        private bool pcMenuAnimating;
        private bool pcMenuAnimatingToMinimized;
        private float pcMenuAnimationStartTime;
        private Vector2 pcMenuAnimationStartPos;
        private Vector2 pcMenuAnimationTargetPos;
        private Vector3 pcMenuAnimationStartScale = Vector3.one;
        private Vector3 pcMenuAnimationTargetScale = Vector3.one;
        private Vector3 pcMenuNotchAnimationStartScale = Vector3.one;
        private Vector3 pcMenuNotchAnimationTargetScale = Vector3.one;
        private float pcMenuNotchAnimationStartAlpha;
        private float pcMenuNotchAnimationTargetAlpha;
        private Vector2 pcMenuRestorePosition = Vector2.zero;
        private bool pcSettingsMode;
        private string pcPreviousCategoryName = "Room Mods";
        private TextMeshProUGUI pcCategoryPageLabel;
        private Button pcCategoryPrevButton;
        private Button pcCategoryNextButton;
        private readonly List<Button> pcCategorySlotButtons = new List<Button>();
        private readonly List<TextMeshProUGUI> pcCategorySlotTexts = new List<TextMeshProUGUI>();
        private readonly List<Image> pcCategorySlotImages = new List<Image>();
        private readonly List<string> pcCategorySlotCategoryNames = new List<string>();
        private readonly List<TextMeshProUGUI> pcCategoryTexts = new List<TextMeshProUGUI>();
        private readonly List<Image> pcCategoryButtonImages = new List<Image>();
        private int pcCategoryPage;
        private const int PcCategoriesPerPage = 7;
        private string pcSelectedCategoryName = "Room Mods";
        private static readonly string[] PcCategories =
        {
            "Room Mods",
            "Important Mods",
            "Safety Mods",
            "Movement Mods",
            "Advantage Mods",
            "Visual Mods",
            "Fun Mods",
            "Sound Mods",
            "Projectile Mods",
            "Master Mods",
            "Overpowered Mods",
            "Experimental Mods",
            "Detected Mods"
        };
        private static readonly Vector2 PcModsPanelDefaultPosition = new Vector2(340f, -88f);
        private static readonly Vector2 PcModsPanelDefaultSize = new Vector2(520f, 452f);
        private static readonly Vector2 PcModsPanelSettingsPosition = new Vector2(24f, -88f);
        private static readonly Vector2 PcModsPanelSettingsSize = new Vector2(852f, 452f);
        private const float PcMenuAnimationDuration = 0.28f;
        private GameObject pcModsPanel;
        private RectTransform pcModsPanelRect;
        private TextMeshProUGUI pcModsTitleLabel;
        private TextMeshProUGUI pcModsPageLabel;
        private TMP_InputField pcModsSearchInput;
        private Button pcModsPrevButton;
        private Button pcModsNextButton;
        private readonly List<Button> pcModSlotButtons = new List<Button>();
        private readonly List<TextMeshProUGUI> pcModSlotTexts = new List<TextMeshProUGUI>();
        private readonly List<Image> pcModSlotImages = new List<Image>();
        private readonly List<ButtonInfo> pcModSlotInfos = new List<ButtonInfo>();
        private readonly List<TextMeshProUGUI> pcModUiTexts = new List<TextMeshProUGUI>();
        private readonly List<Image> pcModUiImages = new List<Image>();
        private int pcModsPage;
        private string pcModsSearchQuery = string.Empty;
        private const int PcModsPerPage = 7;
        private List<TextMeshProUGUI> textObjects;
        private List<Image> imageObjects = new List<Image>();

        private float uiUpdateDelay;

        private void Update()
        {
            if (UnityInput.Current.GetKeyDown(KeyCode.Backslash))
                ToggleGUI();

            if (isOpen)
            {
                uiPrefab.SetActive(true);

                if (!XRSettings.isDeviceActive)
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                }

                UpdatePcMenuAnimation();

                if (UnityInput.Current.GetKeyDown(KeyCode.BackQuote))
                    ToggleDebug();

                Color guiColor = Buttons.GetIndex("Swap GUI Colors").enabled
                    ? textColors[1].GetCurrentColor()
                    : backgroundColor.GetCurrentColor();

                versionLabel.color = guiColor;
                roomStatus.color = guiColor;
                arraylist.color = guiColor;
                watermark.color = guiColor;

                versionLabel.SafeSetFont(activeFont);
                roomStatus.SafeSetFont(activeFont);
                arraylist.SafeSetFont(activeFont);

                versionLabel.SafeSetFontStyle(activeFontStyle);
                roomStatus.SafeSetFontStyle(activeFontStyle);
                arraylist.SafeSetFontStyle(activeFontStyle);

                controlBackground.color = backgroundColor.GetCurrentColor();
                if (pcMenuBackground != null)
                {
                    Color panelColor = backgroundColor.GetCurrentColor();
                    panelColor.a = 0.92f;
                    pcMenuBackground.color = panelColor;

                    bool showPcMenu = !XRSettings.isDeviceActive && (!pcMenuMinimized || pcMenuAnimating);
                    pcMenuBackground.gameObject.SetActive(showPcMenu);
                }

                if (pcTimeLabel != null)
                {
                    pcTimeLabel.gameObject.SetActive(!XRSettings.isDeviceActive);
                    pcTimeLabel.SafeSetText(DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture));
                    pcTimeLabel.color = textColors[1].GetCurrentColor();
                    pcTimeLabel.SafeSetFont(activeFont);
                    pcTimeLabel.SafeSetFontStyle(activeFontStyle);
                }

                if (pcDateLabel != null)
                {
                    pcDateLabel.gameObject.SetActive(!XRSettings.isDeviceActive);
                    pcDateLabel.SafeSetText(DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                    pcDateLabel.color = textColors[1].GetCurrentColor();
                    pcDateLabel.SafeSetFont(activeFont);
                    pcDateLabel.SafeSetFontStyle(activeFontStyle);
                }

                if (pcMenuNameLabel != null)
                {
                    pcMenuNameLabel.gameObject.SetActive(!XRSettings.isDeviceActive);
                    pcMenuNameLabel.SafeSetText(FollowMenuSettings(PluginInfo.Name));
                    pcMenuNameLabel.color = textColors[0].GetCurrentColor();
                    pcMenuNameLabel.SafeSetFont(activeFont);
                    pcMenuNameLabel.SafeSetFontStyle(activeFontStyle);
                }

                if (pcSettingsButton != null)
                    pcSettingsButton.gameObject.SetActive(!XRSettings.isDeviceActive);

                if (pcSettingsButtonImage != null)
                    pcSettingsButtonImage.color = pcSettingsMode
                        ? buttonColors[1].GetCurrentColor()
                        : buttonColors[0].GetCurrentColor();

                if (pcSettingsButtonLabel != null)
                {
                    pcSettingsButtonLabel.SafeSetText(pcSettingsMode ? "Back" : "Settings");
                    pcSettingsButtonLabel.color = pcSettingsMode
                        ? textColors[2].GetCurrentColor()
                        : textColors[1].GetCurrentColor();
                    pcSettingsButtonLabel.SafeSetFont(activeFont);
                    pcSettingsButtonLabel.SafeSetFontStyle(activeFontStyle);
                }

                if (pcMinimizeButton != null)
                    pcMinimizeButton.gameObject.SetActive(!XRSettings.isDeviceActive && (!pcMenuMinimized || pcMenuAnimating));

                if (pcMinimizeButtonImage != null)
                    pcMinimizeButtonImage.color = buttonColors[0].GetCurrentColor();

                if (pcMinimizeButtonLabel != null)
                {
                    pcMinimizeButtonLabel.color = textColors[1].GetCurrentColor();
                    pcMinimizeButtonLabel.SafeSetFont(activeFont);
                    pcMinimizeButtonLabel.SafeSetFontStyle(activeFontStyle);
                }

                if (pcMenuNotchButton != null)
                {
                    bool showNotch = !XRSettings.isDeviceActive &&
                        (pcMenuMinimized || (pcMenuAnimating && pcMenuAnimatingToMinimized));
                    pcMenuNotchButton.gameObject.SetActive(showNotch);
                    pcMenuNotchButton.interactable = showNotch && pcMenuMinimized && !pcMenuAnimating;
                }

                if (pcMenuNotchCanvasGroup != null)
                {
                    bool notchClickable = pcMenuMinimized && !pcMenuAnimating;
                    pcMenuNotchCanvasGroup.interactable = notchClickable;
                    pcMenuNotchCanvasGroup.blocksRaycasts = notchClickable;
                }

                if (pcMenuNotchImage != null)
                    pcMenuNotchImage.color = buttonColors[0].GetCurrentColor();

                if (pcMenuNotchLabel != null)
                {
                    pcMenuNotchLabel.color = textColors[1].GetCurrentColor();
                    pcMenuNotchLabel.SafeSetFont(activeFont);
                    pcMenuNotchLabel.SafeSetFontStyle(activeFontStyle);
                }

                ApplyPcSettingsLayout();

                if (pcCategorySidebar != null)
                {
                    foreach (Image categoryButton in pcCategoryButtonImages)
                        categoryButton.color = buttonColors[0].GetCurrentColor();

                    foreach (TextMeshProUGUI categoryText in pcCategoryTexts)
                    {
                        categoryText.color = textColors[1].GetCurrentColor();
                        categoryText.SafeSetFont(activeFont);
                        categoryText.SafeSetFontStyle(activeFontStyle);
                    }

                    ApplyPcCategorySelectionStyles();
                }

                if (pcModsPanel != null)
                {
                    pcModsPanel.SetActive(!XRSettings.isDeviceActive);

                    foreach (Image modUiImage in pcModUiImages)
                        modUiImage.color = buttonColors[0].GetCurrentColor();

                    foreach (TextMeshProUGUI modUiText in pcModUiTexts)
                    {
                        modUiText.color = textColors[1].GetCurrentColor();
                        modUiText.SafeSetFont(activeFont);
                        modUiText.SafeSetFontStyle(activeFontStyle);
                    }

                    ApplyPcModStyles();
                }

                foreach (var textObject in textObjects)
                {
                    textObject.color = textColors[1].GetCurrentColor();
                    textObject.SafeSetFont(activeFont);
                    textObject.SafeSetFontStyle(activeFontStyle);
                }

                foreach (var imageObject in imageObjects)
                    imageObject.color = buttonColors[0].GetCurrentColor();

                watermark.transform.rotation = Quaternion.Euler(0f, 0f, rockWatermark ? Mathf.Sin(Time.time * 2f) * 10f : 0f);
                versionLabel.SafeSetText(FollowMenuSettings("Build") + " " + PluginInfo.Version + "\n" +
                                    serverLink.Replace("https://", ""));

                roomStatus.SafeSetText(FollowMenuSettings(!PhotonNetwork.InRoom ? "Not connected to room" : "Connected to room ") +
                   (PhotonNetwork.InRoom ? PhotonNetwork.CurrentRoom.Name : ""));

                if (debugUI.activeSelf)
                {
                    debugUI.GetComponent<Image>().color = backgroundColor.GetCurrentColor();

                    List<TextMeshProUGUI> debugTextObjects = new List<TextMeshProUGUI>
                    {
                        debugUI.transform.Find("Title").GetComponent<TextMeshProUGUI>(),
                        debugUI.transform.Find("TextInput/Text Area/Text").GetComponent<TextMeshProUGUI>(),
                        debugUI.transform.Find("TextInput/Text Area/Placeholder").GetComponent<TextMeshProUGUI>()
                    };

                    debugTextObjects.AddRange(debugUI.transform.Find("Lines").GetComponentsInChildren<TextMeshProUGUI>());

                    foreach (var textObject in debugTextObjects)
                    {
                        textObject.color = textColors[1].GetCurrentColor();
                        textObject.SafeSetFont(activeFont);
                        textObject.SafeSetFontStyle(activeFontStyle);
                    }

                    debugUI.transform.Find("Title").GetComponent<TextMeshProUGUI>().color = textColors[0].GetCurrentColor();
                }

                if (!(Time.time > uiUpdateDelay)) return;
                Texture2D watermarkTexture = customWatermark ?? watermarkImage;

                if (watermark.sprite == null || watermark.sprite.texture == null || watermark.sprite.texture != watermarkTexture)
                {
                    Sprite sprite = Sprite.Create(
                        watermarkTexture,
                        new Rect(0, 0, watermarkTexture.width, watermarkTexture.height),
                        new Vector2(0.5f, 0.5f),
                        100f
                    );

                    watermark.sprite = sprite;
                }
                   
                if (flipArraylist)
                {
                    controlBackground.rectTransform.anchoredPosition = new Vector2(10f, -10f);
                    controlBackground.rectTransform.anchorMin = new Vector2(0f, 1f);
                    controlBackground.rectTransform.anchorMax = new Vector2(0f, 1f);

                    arraylist.rectTransform.anchoredPosition = new Vector2(-837.5001f, -523f);
                    arraylist.rectTransform.anchorMin = new Vector2(1f, 1f);
                    arraylist.rectTransform.anchorMax = new Vector2(1f, 1f);

                    arraylist.alignment = TextAlignmentOptions.TopRight;
                }
                else
                {
                    controlBackground.rectTransform.anchoredPosition = new Vector2(-250f, -10f);
                    controlBackground.rectTransform.anchorMin = new Vector2(1f, 1f);
                    controlBackground.rectTransform.anchorMax = new Vector2(1f, 1f);

                    arraylist.rectTransform.anchoredPosition = new Vector2(837.5001f, -523f);
                    arraylist.rectTransform.anchorMin = new Vector2(0f, 1f);
                    arraylist.rectTransform.anchorMax = new Vector2(0f, 1f);

                    arraylist.alignment = TextAlignmentOptions.TopLeft;
                }

                uiUpdateDelay = Time.time + (advancedArraylist ? 0.1f : 0.5f);

                List<string> enabledMods = new List<string>();
                int categoryIndex = 0;

                foreach (ButtonInfo[] buttonList in Buttons.buttons)
                {
                    foreach (ButtonInfo button in buttonList)
                    {
                        try
                        {
                            if (!button.enabled || (hideSettings && (!hideSettings ||
                                                                     Buttons.categoryNames[categoryIndex]
                                                                         .Contains("Settings")))) continue;
                            string buttonText = button.overlapText ?? button.buttonText;

                            if (inputTextColor != "green")
                                buttonText = buttonText.Replace(" <color=grey>[</color><color=green>", " <color=grey>[</color><color=" + inputTextColor + ">");

                            buttonText = FixTMProTags(buttonText);

                            buttonText = FollowMenuSettings(buttonText);
                            enabledMods.Add(buttonText);
                        }
                        catch { }
                    }
                    categoryIndex++;
                }

                string[] sortedMods = enabledMods
                    .OrderByDescending(s => arraylist.GetPreferredValues(NoRichtextTags(s)).x)
                    .ToArray();

                string modListText = "";
                for (int i = 0; i < sortedMods.Length; i++)
                {
                    if (advancedArraylist)
                        modListText += (flipArraylist ?
                            /* Flipped */ $"<mark=#{ColorToHex(backgroundColor.GetCurrentColor(i * -0.1f))}C0> {sortedMods[i]} </mark><mark=#{ColorToHex(buttonColors[1].GetCurrentColor(i * -0.1f))}> </mark>" :
                            /* Normal  */ $"<mark=#{ColorToHex(buttonColors[1].GetCurrentColor(i * -0.1f))}> </mark><mark=#{ColorToHex(backgroundColor.GetCurrentColor(i * -0.1f))}C0> {sortedMods[i]} </mark>") + "\n";
                    else
                        modListText += sortedMods[i] + "\n";
                }

                arraylist.SafeSetText(modListText);
            }
            else
            {
                if (pcMenuAnimating)
                {
                    pcMenuMinimized = pcMenuAnimatingToMinimized;
                    pcMenuAnimating = false;
                }

                uiPrefab.SetActive(false);
                if (pcMenuBackground != null)
                    pcMenuBackground.gameObject.SetActive(false);
                if (pcMenuNotchButton != null)
                    pcMenuNotchButton.gameObject.SetActive(false);
                if (pcCategorySidebar != null)
                    pcCategorySidebar.SetActive(false);
                if (pcModsPanel != null)
                    pcModsPanel.SetActive(false);
                if (pcTimeLabel != null)
                    pcTimeLabel.gameObject.SetActive(false);
                if (pcDateLabel != null)
                    pcDateLabel.gameObject.SetActive(false);
                if (pcMenuNameLabel != null)
                    pcMenuNameLabel.gameObject.SetActive(false);
            }
        }

        private readonly string hideGUIPath = $"{PluginInfo.BaseDirectory}/iiMenu_HideGUI.txt";
        private void ToggleGUI()
        {
            isOpen = !isOpen;
            if (isOpen)
            {
                if (File.Exists(hideGUIPath))
                    File.Delete(hideGUIPath);
            }
            else
            {
                if (!File.Exists(hideGUIPath))
                    File.WriteAllText(hideGUIPath, "Text file generated with ii's Stupid Menu");
            }

            GameObject closeMessage = uiPrefab.transform.Find("Canvas")?.Find("HideMessage")?.gameObject;
            closeMessage?.SetActive(false);
        }

        private static Sprite GetRoundedControlBackgroundSprite()
        {
            if (roundedControlBackgroundSprite != null)
                return roundedControlBackgroundSprite;

            const int size = 64;
            const int radius = 12;

            Texture2D texture = new Texture2D(size, size, TextureFormat.ARGB32, false)
            {
                name = "iiMenu_ControlUIRoundedBackground"
            };
            texture.wrapMode = TextureWrapMode.Clamp;
            texture.filterMode = FilterMode.Bilinear;

            Color32[] pixels = new Color32[size * size];
            Color32 solid = new Color32(255, 255, 255, 255);
            Color32 transparent = new Color32(255, 255, 255, 0);

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    float px = x + 0.5f;
                    float py = y + 0.5f;
                    float nearestX = Mathf.Clamp(px, radius, size - radius);
                    float nearestY = Mathf.Clamp(py, radius, size - radius);
                    float dx = px - nearestX;
                    float dy = py - nearestY;
                    bool insideRoundedRect = (dx * dx) + (dy * dy) <= radius * radius;

                    pixels[(y * size) + x] = insideRoundedRect ? solid : transparent;
                }
            }

            texture.SetPixels32(pixels);
            texture.Apply();

            roundedControlBackgroundSprite = Sprite.Create(
                texture,
                new Rect(0f, 0f, size, size),
                new Vector2(0.5f, 0.5f),
                100f,
                0u,
                SpriteMeshType.FullRect,
                new Vector4(radius, radius, radius, radius)
            );

            return roundedControlBackgroundSprite;
        }

        private void CreatePcMenuBackground(Transform canvas)
        {
            if (canvas == null || canvas.Find("PCMenuBackground") != null)
                return;

            GameObject backgroundObject = new GameObject("PCMenuBackground");
            backgroundObject.transform.SetParent(canvas, false);
            backgroundObject.transform.SetAsLastSibling();

            RectTransform rectTransform = backgroundObject.AddComponent<RectTransform>();
            rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
            rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
            rectTransform.pivot = new Vector2(0.5f, 0.5f);
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = new Vector2(900f, 560f);
            pcMenuBackgroundRect = rectTransform;

            pcMenuBackground = backgroundObject.AddComponent<Image>();
            pcMenuBackground.raycastTarget = false;
            pcMenuBackground.sprite = GetRoundedControlBackgroundSprite();
            pcMenuBackground.type = Image.Type.Sliced;
            pcMenuBackground.gameObject.SetActive(!XRSettings.isDeviceActive);
            pcMenuBackgroundRect.localScale = Vector3.one;

            CreatePcDragHandle(backgroundObject.transform, canvas.GetComponent<Canvas>());
            CreatePcMenuNotch(canvas);
            CreatePcHeaderInfo(backgroundObject.transform);
            CreatePcCategorySidebar(backgroundObject.transform);
            CreatePcModsPanel(backgroundObject.transform);
            SetPcCategory(pcSelectedCategoryName, false);
            ApplyPcSettingsLayout();
        }

        private void CreatePcDragHandle(Transform parent, Canvas canvas)
        {
            if (parent == null || pcMenuBackgroundRect == null)
                return;

            GameObject dragObject = new GameObject("PCDragHandle");
            dragObject.transform.SetParent(parent, false);

            RectTransform dragRect = dragObject.AddComponent<RectTransform>();
            dragRect.anchorMin = new Vector2(0f, 1f);
            dragRect.anchorMax = new Vector2(1f, 1f);
            dragRect.pivot = new Vector2(0.5f, 1f);
            dragRect.anchoredPosition = Vector2.zero;
            dragRect.sizeDelta = new Vector2(0f, 74f);

            Image dragImage = dragObject.AddComponent<Image>();
            dragImage.color = new Color(0f, 0f, 0f, 0f);
            dragImage.raycastTarget = true;

            PcMenuDragHandle dragHandle = dragObject.AddComponent<PcMenuDragHandle>();
            dragHandle.Initialize(pcMenuBackgroundRect, canvas);
        }

        private void CreatePcMenuNotch(Transform canvas)
        {
            if (canvas == null || canvas.Find("PCMenuNotch") != null)
                return;

            GameObject notchObject = new GameObject("PCMenuNotch");
            notchObject.transform.SetParent(canvas, false);

            RectTransform notchRect = notchObject.AddComponent<RectTransform>();
            notchRect.anchorMin = new Vector2(0.5f, 0f);
            notchRect.anchorMax = new Vector2(0.5f, 0f);
            notchRect.pivot = new Vector2(0.5f, 0f);
            notchRect.anchoredPosition = new Vector2(0f, 14f);
            notchRect.sizeDelta = new Vector2(236f, 42f);
            notchRect.localScale = new Vector3(0.38f, 0.38f, 1f);
            pcMenuNotchRect = notchRect;

            Image notchImage = notchObject.AddComponent<Image>();
            notchImage.sprite = GetRoundedControlBackgroundSprite();
            notchImage.type = Image.Type.Sliced;
            notchImage.color = buttonColors[0].GetCurrentColor();
            pcMenuNotchImage = notchImage;

            pcMenuNotchButton = notchObject.AddComponent<Button>();
            pcMenuNotchButton.targetGraphic = notchImage;
            pcMenuNotchButton.onClick.AddListener(RestorePcMenu);

            GameObject notchTextObject = new GameObject("Text");
            notchTextObject.transform.SetParent(notchObject.transform, false);

            RectTransform notchTextRect = notchTextObject.AddComponent<RectTransform>();
            notchTextRect.anchorMin = Vector2.zero;
            notchTextRect.anchorMax = Vector2.one;
            notchTextRect.offsetMin = Vector2.zero;
            notchTextRect.offsetMax = Vector2.zero;

            pcMenuNotchLabel = notchTextObject.AddComponent<TextMeshProUGUI>();
            pcMenuNotchLabel.SafeSetText("ii stupid menu");
            pcMenuNotchLabel.alignment = TextAlignmentOptions.Center;
            pcMenuNotchLabel.fontSize = 22f;
            pcMenuNotchLabel.raycastTarget = false;
            pcMenuNotchLabel.color = textColors[1].GetCurrentColor();

            pcMenuNotchCanvasGroup = notchObject.AddComponent<CanvasGroup>();
            pcMenuNotchCanvasGroup.alpha = 0f;
            pcMenuNotchCanvasGroup.interactable = false;
            pcMenuNotchCanvasGroup.blocksRaycasts = false;

            notchObject.SetActive(false);
        }

        private void MinimizePcMenu()
        {
            if (pcMenuBackgroundRect == null || pcMenuAnimating || pcMenuMinimized)
                return;

            pcMenuRestorePosition = pcMenuBackgroundRect.anchoredPosition;
            if (pcMenuNotchButton != null)
                pcMenuNotchButton.gameObject.SetActive(!XRSettings.isDeviceActive && isOpen);
            StartPcMenuAnimation(true);
            PlayButtonSound();
        }

        private void RestorePcMenu()
        {
            if (pcMenuBackgroundRect == null || pcMenuAnimating || !pcMenuMinimized)
                return;

            StartPcMenuAnimation(false);
            PlayButtonSound();
        }

        private void StartPcMenuAnimation(bool minimize)
        {
            if (pcMenuBackgroundRect == null)
                return;

            Vector2 hiddenPosition = GetPcMenuHiddenPosition();
            Vector3 minimizedMenuScale = new Vector3(0.88f, 0.88f, 1f);
            Vector3 hiddenNotchScale = new Vector3(0.38f, 0.3f, 1f);

            if (!minimize)
            {
                if (pcMenuBackground != null)
                    pcMenuBackground.gameObject.SetActive(!XRSettings.isDeviceActive);

                pcMenuBackgroundRect.anchoredPosition = hiddenPosition;
                pcMenuBackgroundRect.localScale = minimizedMenuScale;
            }

            pcMenuAnimating = true;
            pcMenuAnimatingToMinimized = minimize;
            pcMenuAnimationStartTime = Time.unscaledTime;
            pcMenuAnimationStartPos = pcMenuBackgroundRect.anchoredPosition;
            pcMenuAnimationStartScale = pcMenuBackgroundRect.localScale;
            pcMenuAnimationTargetPos = minimize ? hiddenPosition : pcMenuRestorePosition;
            pcMenuAnimationTargetScale = minimize ? minimizedMenuScale : Vector3.one;

            if (pcMenuNotchButton != null)
                pcMenuNotchButton.gameObject.SetActive(!XRSettings.isDeviceActive && isOpen);

            if (minimize)
            {
                if (pcMenuNotchRect != null)
                    pcMenuNotchRect.localScale = hiddenNotchScale;

                if (pcMenuNotchCanvasGroup != null)
                    pcMenuNotchCanvasGroup.alpha = 0f;
            }

            pcMenuNotchAnimationStartScale = pcMenuNotchRect != null ? pcMenuNotchRect.localScale : Vector3.one;
            pcMenuNotchAnimationTargetScale = minimize ? Vector3.one : hiddenNotchScale;
            pcMenuNotchAnimationStartAlpha = pcMenuNotchCanvasGroup != null ? pcMenuNotchCanvasGroup.alpha : (minimize ? 0f : 1f);
            pcMenuNotchAnimationTargetAlpha = minimize ? 1f : 0f;

            if (pcMenuNotchCanvasGroup != null)
            {
                pcMenuNotchCanvasGroup.interactable = false;
                pcMenuNotchCanvasGroup.blocksRaycasts = false;
            }
        }

        private void UpdatePcMenuAnimation()
        {
            if (!pcMenuAnimating || pcMenuBackgroundRect == null)
                return;

            float elapsed = Time.unscaledTime - pcMenuAnimationStartTime;
            float progress = Mathf.Clamp01(elapsed / PcMenuAnimationDuration);
            float eased = Mathf.SmoothStep(0f, 1f, progress);
            float wave = Mathf.Sin(eased * Mathf.PI) * 0.085f;

            pcMenuBackgroundRect.anchoredPosition = Vector2.Lerp(pcMenuAnimationStartPos, pcMenuAnimationTargetPos, eased);
            Vector3 menuScale = Vector3.Lerp(pcMenuAnimationStartScale, pcMenuAnimationTargetScale, eased);
            float menuWave = pcMenuAnimatingToMinimized ? wave : (-wave * 0.55f);
            menuScale.x *= 1f + (menuWave * 0.35f);
            menuScale.y *= 1f - (menuWave * 0.55f);
            pcMenuBackgroundRect.localScale = menuScale;

            if (pcMenuNotchRect != null)
            {
                Vector3 notchScale = Vector3.Lerp(pcMenuNotchAnimationStartScale, pcMenuNotchAnimationTargetScale, eased);
                float notchWave = pcMenuAnimatingToMinimized ? wave : (-wave * 0.7f);
                notchScale.x *= 1f + notchWave;
                notchScale.y *= 1f - (notchWave * 0.6f);
                pcMenuNotchRect.localScale = notchScale;
            }

            if (pcMenuNotchCanvasGroup != null)
                pcMenuNotchCanvasGroup.alpha = Mathf.Lerp(pcMenuNotchAnimationStartAlpha, pcMenuNotchAnimationTargetAlpha, eased);

            if (progress < 1f)
                return;

            pcMenuAnimating = false;
            pcMenuMinimized = pcMenuAnimatingToMinimized;

            if (pcMenuMinimized)
            {
                if (pcMenuBackground != null)
                    pcMenuBackground.gameObject.SetActive(false);

                if (pcMenuNotchButton != null)
                    pcMenuNotchButton.gameObject.SetActive(!XRSettings.isDeviceActive && isOpen);

                if (pcMenuNotchRect != null)
                    pcMenuNotchRect.localScale = Vector3.one;

                if (pcMenuNotchCanvasGroup != null)
                {
                    pcMenuNotchCanvasGroup.alpha = 1f;
                    pcMenuNotchCanvasGroup.interactable = true;
                    pcMenuNotchCanvasGroup.blocksRaycasts = true;
                }
            }
            else
            {
                pcMenuBackgroundRect.localScale = Vector3.one;

                if (pcMenuNotchCanvasGroup != null)
                {
                    pcMenuNotchCanvasGroup.alpha = 0f;
                    pcMenuNotchCanvasGroup.interactable = false;
                    pcMenuNotchCanvasGroup.blocksRaycasts = false;
                }

                if (pcMenuNotchRect != null)
                    pcMenuNotchRect.localScale = new Vector3(0.38f, 0.3f, 1f);

                if (pcMenuNotchButton != null)
                    pcMenuNotchButton.gameObject.SetActive(false);
            }
        }

        private Vector2 GetPcMenuHiddenPosition()
        {
            if (pcMenuBackgroundRect == null)
                return new Vector2(0f, -900f);

            RectTransform parentRect = pcMenuBackgroundRect.parent as RectTransform;
            if (parentRect == null)
                return new Vector2(0f, -900f);

            float parentHalfHeight = parentRect.rect.height * 0.5f;
            float menuHalfHeight = pcMenuBackgroundRect.rect.height * 0.5f;
            return new Vector2(0f, -(parentHalfHeight + menuHalfHeight + 36f));
        }

        private static void EnsurePcUiInput(Transform canvas)
        {
            if (canvas == null)
                return;

            if (canvas.GetComponent<GraphicRaycaster>() == null)
                canvas.gameObject.AddComponent<GraphicRaycaster>();

            EventSystem currentEventSystem = EventSystem.current;
            if (currentEventSystem == null)
            {
                GameObject eventSystemObject = new GameObject("iiMenu_PCEventSystem");
                currentEventSystem = eventSystemObject.AddComponent<EventSystem>();
            }

            if (currentEventSystem.GetComponent<BaseInputModule>() == null)
                currentEventSystem.gameObject.AddComponent<StandaloneInputModule>();
        }

        private void CreatePcHeaderInfo(Transform parent)
        {
            if (parent == null)
                return;

            GameObject menuNameObject = new GameObject("PCMenuName");
            menuNameObject.transform.SetParent(parent, false);

            RectTransform menuNameRect = menuNameObject.AddComponent<RectTransform>();
            menuNameRect.anchorMin = new Vector2(0.5f, 1f);
            menuNameRect.anchorMax = new Vector2(0.5f, 1f);
            menuNameRect.pivot = new Vector2(0.5f, 1f);
            menuNameRect.anchoredPosition = new Vector2(0f, -16f);
            menuNameRect.sizeDelta = new Vector2(620f, 56f);

            pcMenuNameLabel = menuNameObject.AddComponent<TextMeshProUGUI>();
            pcMenuNameLabel.alignment = TextAlignmentOptions.Center;
            pcMenuNameLabel.fontSize = 42f;
            pcMenuNameLabel.raycastTarget = false;
            pcMenuNameLabel.SafeSetText(PluginInfo.Name);

            GameObject timeObject = new GameObject("PCTime");
            timeObject.transform.SetParent(parent, false);

            RectTransform timeRect = timeObject.AddComponent<RectTransform>();
            timeRect.anchorMin = new Vector2(0f, 1f);
            timeRect.anchorMax = new Vector2(0f, 1f);
            timeRect.pivot = new Vector2(0f, 1f);
            timeRect.anchoredPosition = new Vector2(24f, -20f);
            timeRect.sizeDelta = new Vector2(280f, 36f);

            pcTimeLabel = timeObject.AddComponent<TextMeshProUGUI>();
            pcTimeLabel.alignment = TextAlignmentOptions.Left;
            pcTimeLabel.fontSize = 30f;
            pcTimeLabel.raycastTarget = false;
            pcTimeLabel.SafeSetText(DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture));

            GameObject dateObject = new GameObject("PCDate");
            dateObject.transform.SetParent(parent, false);

            RectTransform dateRect = dateObject.AddComponent<RectTransform>();
            dateRect.anchorMin = new Vector2(0f, 1f);
            dateRect.anchorMax = new Vector2(0f, 1f);
            dateRect.pivot = new Vector2(0f, 1f);
            dateRect.anchoredPosition = new Vector2(24f, -58f);
            dateRect.sizeDelta = new Vector2(280f, 28f);

            pcDateLabel = dateObject.AddComponent<TextMeshProUGUI>();
            pcDateLabel.alignment = TextAlignmentOptions.Left;
            pcDateLabel.fontSize = 22f;
            pcDateLabel.raycastTarget = false;
            pcDateLabel.SafeSetText(DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));

            GameObject settingsObject = new GameObject("PCSettingsButton");
            settingsObject.transform.SetParent(parent, false);

            RectTransform settingsRect = settingsObject.AddComponent<RectTransform>();
            settingsRect.anchorMin = new Vector2(1f, 1f);
            settingsRect.anchorMax = new Vector2(1f, 1f);
            settingsRect.pivot = new Vector2(1f, 1f);
            settingsRect.anchoredPosition = new Vector2(-76f, -20f);
            settingsRect.sizeDelta = new Vector2(148f, 40f);

            Image settingsImage = settingsObject.AddComponent<Image>();
            settingsImage.sprite = GetRoundedControlBackgroundSprite();
            settingsImage.type = Image.Type.Sliced;
            settingsImage.color = buttonColors[0].GetCurrentColor();
            pcSettingsButtonImage = settingsImage;

            pcSettingsButton = settingsObject.AddComponent<Button>();
            pcSettingsButton.targetGraphic = settingsImage;
            pcSettingsButton.onClick.AddListener(TogglePcSettingsMode);

            GameObject settingsTextObject = new GameObject("Text");
            settingsTextObject.transform.SetParent(settingsObject.transform, false);

            RectTransform settingsTextRect = settingsTextObject.AddComponent<RectTransform>();
            settingsTextRect.anchorMin = Vector2.zero;
            settingsTextRect.anchorMax = Vector2.one;
            settingsTextRect.offsetMin = Vector2.zero;
            settingsTextRect.offsetMax = Vector2.zero;

            TextMeshProUGUI settingsText = settingsTextObject.AddComponent<TextMeshProUGUI>();
            settingsText.SafeSetText("Settings");
            settingsText.alignment = TextAlignmentOptions.Center;
            settingsText.fontSize = 24f;
            settingsText.raycastTarget = false;
            settingsText.color = textColors[1].GetCurrentColor();
            pcSettingsButtonLabel = settingsText;

            GameObject minimizeObject = new GameObject("PCMinimizeButton");
            minimizeObject.transform.SetParent(parent, false);

            RectTransform minimizeRect = minimizeObject.AddComponent<RectTransform>();
            minimizeRect.anchorMin = new Vector2(1f, 1f);
            minimizeRect.anchorMax = new Vector2(1f, 1f);
            minimizeRect.pivot = new Vector2(1f, 1f);
            minimizeRect.anchoredPosition = new Vector2(-24f, -20f);
            minimizeRect.sizeDelta = new Vector2(44f, 40f);

            Image minimizeImage = minimizeObject.AddComponent<Image>();
            minimizeImage.sprite = GetRoundedControlBackgroundSprite();
            minimizeImage.type = Image.Type.Sliced;
            minimizeImage.color = buttonColors[0].GetCurrentColor();
            pcMinimizeButtonImage = minimizeImage;

            pcMinimizeButton = minimizeObject.AddComponent<Button>();
            pcMinimizeButton.targetGraphic = minimizeImage;
            pcMinimizeButton.onClick.AddListener(MinimizePcMenu);

            GameObject minimizeTextObject = new GameObject("Text");
            minimizeTextObject.transform.SetParent(minimizeObject.transform, false);

            RectTransform minimizeTextRect = minimizeTextObject.AddComponent<RectTransform>();
            minimizeTextRect.anchorMin = Vector2.zero;
            minimizeTextRect.anchorMax = Vector2.one;
            minimizeTextRect.offsetMin = Vector2.zero;
            minimizeTextRect.offsetMax = new Vector2(0f, 2f);

            TextMeshProUGUI minimizeText = minimizeTextObject.AddComponent<TextMeshProUGUI>();
            minimizeText.SafeSetText("-");
            minimizeText.alignment = TextAlignmentOptions.Center;
            minimizeText.fontSize = 36f;
            minimizeText.raycastTarget = false;
            minimizeText.color = textColors[1].GetCurrentColor();
            pcMinimizeButtonLabel = minimizeText;
        }

        private void CreatePcCategorySidebar(Transform parent)
        {
            if (parent == null)
                return;

            Transform existing = parent.Find("Categories");
            if (existing != null)
                UnityEngine.Object.Destroy(existing.gameObject);

            pcCategoryTexts.Clear();
            pcCategoryButtonImages.Clear();
            pcCategorySlotButtons.Clear();
            pcCategorySlotTexts.Clear();
            pcCategorySlotImages.Clear();
            pcCategorySlotCategoryNames.Clear();
            pcCategoryPage = 0;

            pcCategorySidebar = new GameObject("Categories");
            pcCategorySidebar.transform.SetParent(parent, false);

            RectTransform sidebarRect = pcCategorySidebar.AddComponent<RectTransform>();
            sidebarRect.anchorMin = new Vector2(0f, 1f);
            sidebarRect.anchorMax = new Vector2(0f, 1f);
            sidebarRect.pivot = new Vector2(0f, 1f);
            sidebarRect.anchoredPosition = new Vector2(16f, -88f);
            float categoryButtonWidth = GetPcCategoryButtonWidth(24f);
            sidebarRect.sizeDelta = new Vector2(categoryButtonWidth + 8f, 452f);

            GameObject categoryList = new GameObject("CategoryList");
            categoryList.transform.SetParent(pcCategorySidebar.transform, false);

            RectTransform listRect = categoryList.AddComponent<RectTransform>();
            listRect.anchorMin = new Vector2(0f, 1f);
            listRect.anchorMax = new Vector2(0f, 1f);
            listRect.pivot = new Vector2(0f, 1f);
            listRect.anchoredPosition = new Vector2(0f, 0f);
            listRect.sizeDelta = new Vector2(categoryButtonWidth, 400f);

            const float slotHeight = 50f;
            const float slotSpacing = 8f;
            const float topPadding = 2f;
            for (int i = 0; i < PcCategoriesPerPage; i++)
            {
                GameObject categoryButton = new GameObject("CategorySlot" + i);
                categoryButton.transform.SetParent(categoryList.transform, false);

                RectTransform buttonRect = categoryButton.AddComponent<RectTransform>();
                buttonRect.anchorMin = new Vector2(0f, 1f);
                buttonRect.anchorMax = new Vector2(0f, 1f);
                buttonRect.pivot = new Vector2(0f, 1f);
                buttonRect.anchoredPosition = new Vector2(0f, -(topPadding + (i * (slotHeight + slotSpacing))));
                buttonRect.sizeDelta = new Vector2(categoryButtonWidth, slotHeight);

                Image buttonImage = categoryButton.AddComponent<Image>();
                buttonImage.sprite = GetRoundedControlBackgroundSprite();
                buttonImage.type = Image.Type.Sliced;
                buttonImage.color = buttonColors[0].GetCurrentColor();
                pcCategoryButtonImages.Add(buttonImage);
                pcCategorySlotImages.Add(buttonImage);

                Button button = categoryButton.AddComponent<Button>();
                button.targetGraphic = buttonImage;
                pcCategorySlotButtons.Add(button);
                pcCategorySlotCategoryNames.Add(null);

                GameObject labelObject = new GameObject("Text");
                labelObject.transform.SetParent(categoryButton.transform, false);

                RectTransform labelRect = labelObject.AddComponent<RectTransform>();
                labelRect.anchorMin = Vector2.zero;
                labelRect.anchorMax = Vector2.one;
                labelRect.offsetMin = new Vector2(14f, 0f);
                labelRect.offsetMax = new Vector2(-8f, 0f);

                TextMeshProUGUI label = labelObject.AddComponent<TextMeshProUGUI>();
                label.alignment = TextAlignmentOptions.MidlineLeft;
                label.fontSize = 24f;
                label.raycastTarget = false;
                label.color = textColors[1].GetCurrentColor();
                label.SafeSetFont(activeFont);
                label.SafeSetFontStyle(activeFontStyle);
                pcCategoryTexts.Add(label);
                pcCategorySlotTexts.Add(label);
            }

            GameObject navigation = new GameObject("Navigation");
            navigation.transform.SetParent(pcCategorySidebar.transform, false);

            RectTransform navRect = navigation.AddComponent<RectTransform>();
            navRect.anchorMin = new Vector2(0f, 0f);
            navRect.anchorMax = new Vector2(0f, 0f);
            navRect.pivot = new Vector2(0f, 0f);
            navRect.anchoredPosition = new Vector2(0f, -8f);
            navRect.sizeDelta = new Vector2(categoryButtonWidth, 52f);

            GameObject prevObject = new GameObject("PrevPage");
            prevObject.transform.SetParent(navigation.transform, false);

            RectTransform prevRect = prevObject.AddComponent<RectTransform>();
            prevRect.anchorMin = new Vector2(0f, 0f);
            prevRect.anchorMax = new Vector2(0f, 1f);
            prevRect.pivot = new Vector2(0f, 0.5f);
            prevRect.anchoredPosition = new Vector2(0f, 0f);
            prevRect.sizeDelta = new Vector2(60f, 0f);

            Image prevImage = prevObject.AddComponent<Image>();
            prevImage.sprite = GetRoundedControlBackgroundSprite();
            prevImage.type = Image.Type.Sliced;
            prevImage.color = buttonColors[0].GetCurrentColor();
            pcCategoryButtonImages.Add(prevImage);

            pcCategoryPrevButton = prevObject.AddComponent<Button>();
            pcCategoryPrevButton.targetGraphic = prevImage;
            pcCategoryPrevButton.onClick.AddListener(() => ChangePcCategoryPage(-1));

            GameObject prevTextObject = new GameObject("Text");
            prevTextObject.transform.SetParent(prevObject.transform, false);

            RectTransform prevTextRect = prevTextObject.AddComponent<RectTransform>();
            prevTextRect.anchorMin = Vector2.zero;
            prevTextRect.anchorMax = Vector2.one;
            prevTextRect.offsetMin = Vector2.zero;
            prevTextRect.offsetMax = Vector2.zero;

            TextMeshProUGUI prevText = prevTextObject.AddComponent<TextMeshProUGUI>();
            prevText.SafeSetText("<");
            prevText.alignment = TextAlignmentOptions.Center;
            prevText.fontSize = 28f;
            prevText.raycastTarget = false;
            prevText.color = textColors[1].GetCurrentColor();
            pcCategoryTexts.Add(prevText);

            GameObject nextObject = new GameObject("NextPage");
            nextObject.transform.SetParent(navigation.transform, false);

            RectTransform nextRect = nextObject.AddComponent<RectTransform>();
            nextRect.anchorMin = new Vector2(1f, 0f);
            nextRect.anchorMax = new Vector2(1f, 1f);
            nextRect.pivot = new Vector2(1f, 0.5f);
            nextRect.anchoredPosition = new Vector2(0f, 0f);
            nextRect.sizeDelta = new Vector2(60f, 0f);

            Image nextImage = nextObject.AddComponent<Image>();
            nextImage.sprite = GetRoundedControlBackgroundSprite();
            nextImage.type = Image.Type.Sliced;
            nextImage.color = buttonColors[0].GetCurrentColor();
            pcCategoryButtonImages.Add(nextImage);

            pcCategoryNextButton = nextObject.AddComponent<Button>();
            pcCategoryNextButton.targetGraphic = nextImage;
            pcCategoryNextButton.onClick.AddListener(() => ChangePcCategoryPage(1));

            GameObject nextTextObject = new GameObject("Text");
            nextTextObject.transform.SetParent(nextObject.transform, false);

            RectTransform nextTextRect = nextTextObject.AddComponent<RectTransform>();
            nextTextRect.anchorMin = Vector2.zero;
            nextTextRect.anchorMax = Vector2.one;
            nextTextRect.offsetMin = Vector2.zero;
            nextTextRect.offsetMax = Vector2.zero;

            TextMeshProUGUI nextText = nextTextObject.AddComponent<TextMeshProUGUI>();
            nextText.SafeSetText(">");
            nextText.alignment = TextAlignmentOptions.Center;
            nextText.fontSize = 28f;
            nextText.raycastTarget = false;
            nextText.color = textColors[1].GetCurrentColor();
            pcCategoryTexts.Add(nextText);

            GameObject pageLabelObject = new GameObject("PageLabel");
            pageLabelObject.transform.SetParent(navigation.transform, false);

            RectTransform pageLabelRect = pageLabelObject.AddComponent<RectTransform>();
            pageLabelRect.anchorMin = new Vector2(0f, 0f);
            pageLabelRect.anchorMax = new Vector2(1f, 1f);
            pageLabelRect.offsetMin = new Vector2(68f, 0f);
            pageLabelRect.offsetMax = new Vector2(-68f, 0f);

            pcCategoryPageLabel = pageLabelObject.AddComponent<TextMeshProUGUI>();
            pcCategoryPageLabel.alignment = TextAlignmentOptions.Center;
            pcCategoryPageLabel.fontSize = 22f;
            pcCategoryPageLabel.raycastTarget = false;
            pcCategoryPageLabel.color = textColors[1].GetCurrentColor();
            pcCategoryTexts.Add(pcCategoryPageLabel);

            RefreshPcCategorySidebarPage();

            pcCategorySidebar.SetActive(!XRSettings.isDeviceActive && !pcSettingsMode);
        }

        private void RefreshPcCategorySidebarPage()
        {
            if (pcCategorySlotButtons.Count == 0 || pcCategorySlotTexts.Count == 0)
                return;

            int totalPages = Mathf.Max(1, Mathf.CeilToInt(PcCategories.Length / (float)PcCategoriesPerPage));
            pcCategoryPage = Mathf.Clamp(pcCategoryPage, 0, totalPages - 1);

            int startIndex = pcCategoryPage * PcCategoriesPerPage;
            for (int i = 0; i < PcCategoriesPerPage; i++)
            {
                int categoryIndex = startIndex + i;
                bool hasCategory = categoryIndex < PcCategories.Length;

                Button slotButton = pcCategorySlotButtons[i];
                TextMeshProUGUI slotText = pcCategorySlotTexts[i];

                slotButton.gameObject.SetActive(hasCategory);
                pcCategorySlotCategoryNames[i] = hasCategory ? PcCategories[categoryIndex] : null;
                if (!hasCategory)
                    continue;

                string categoryName = PcCategories[categoryIndex];
                slotText.SafeSetText(categoryName);

                slotButton.onClick.RemoveAllListeners();
                slotButton.onClick.AddListener(() => SetPcCategory(categoryName, true));
            }

            if (pcCategoryPrevButton != null)
                pcCategoryPrevButton.interactable = pcCategoryPage > 0;

            if (pcCategoryNextButton != null)
                pcCategoryNextButton.interactable = pcCategoryPage < totalPages - 1;

            if (pcCategoryPageLabel != null)
                pcCategoryPageLabel.SafeSetText((pcCategoryPage + 1) + " / " + totalPages);

            ApplyPcCategorySelectionStyles();
        }

        private void SetPcCategory(string categoryName, bool playSound = false)
        {
            if (string.IsNullOrEmpty(categoryName))
                return;

            pcSelectedCategoryName = categoryName;
            pcModsPage = 0;
            int sidebarCategoryIndex = Array.IndexOf(PcCategories, categoryName);
            if (sidebarCategoryIndex >= 0)
                pcCategoryPage = sidebarCategoryIndex / PcCategoriesPerPage;

            ButtonInfo categoryInfo = Buttons.GetIndex(categoryName);
            if (categoryInfo?.method != null)
                categoryInfo.method.Invoke();
            else
                Buttons.CurrentCategoryName = categoryName;

            RefreshPcCategorySidebarPage();
            RefreshPcModsPage();
            ApplyPcSettingsLayout();

            if (playSound)
                PlayButtonSound();
        }

        private void TogglePcSettingsMode()
        {
            pcSettingsMode = !pcSettingsMode;
            if (pcSettingsMode)
            {
                pcPreviousCategoryName = string.IsNullOrEmpty(pcSelectedCategoryName) ? "Room Mods" : pcSelectedCategoryName;
                SetPcCategory("Menu Settings", false);
            }
            else
            {
                string restoreCategory = string.IsNullOrEmpty(pcPreviousCategoryName) ? "Room Mods" : pcPreviousCategoryName;
                if (Array.IndexOf(PcCategories, restoreCategory) < 0)
                    restoreCategory = "Room Mods";

                SetPcCategory(restoreCategory, false);
            }

            ApplyPcSettingsLayout();
            PlayButtonSound();
        }

        private void ApplyPcSettingsLayout()
        {
            if (pcCategorySidebar != null)
                pcCategorySidebar.SetActive(!XRSettings.isDeviceActive && !pcSettingsMode);

            if (pcModsPanelRect != null)
            {
                pcModsPanelRect.anchoredPosition = pcSettingsMode ? PcModsPanelSettingsPosition : PcModsPanelDefaultPosition;
                pcModsPanelRect.sizeDelta = pcSettingsMode ? PcModsPanelSettingsSize : PcModsPanelDefaultSize;
            }
        }

        private void ApplyPcCategorySelectionStyles()
        {
            for (int i = 0; i < pcCategorySlotImages.Count; i++)
            {
                string slotCategoryName = i < pcCategorySlotCategoryNames.Count ? pcCategorySlotCategoryNames[i] : null;
                if (string.IsNullOrEmpty(slotCategoryName))
                    continue;

                bool isSelected = string.Equals(slotCategoryName, pcSelectedCategoryName, StringComparison.Ordinal);
                pcCategorySlotImages[i].color = isSelected
                    ? buttonColors[1].GetCurrentColor()
                    : buttonColors[0].GetCurrentColor();
            }
        }

        private void CreatePcModsPanel(Transform parent)
        {
            if (parent == null)
                return;

            Transform existing = parent.Find("ModsPanel");
            if (existing != null)
                UnityEngine.Object.Destroy(existing.gameObject);

            pcModUiTexts.Clear();
            pcModUiImages.Clear();
            pcModSlotButtons.Clear();
            pcModSlotTexts.Clear();
            pcModSlotImages.Clear();
            pcModSlotInfos.Clear();
            pcModsPage = 0;

            pcModsPanel = new GameObject("ModsPanel");
            pcModsPanel.transform.SetParent(parent, false);

            RectTransform panelRect = pcModsPanel.AddComponent<RectTransform>();
            panelRect.anchorMin = new Vector2(0f, 1f);
            panelRect.anchorMax = new Vector2(0f, 1f);
            panelRect.pivot = new Vector2(0f, 1f);
            panelRect.anchoredPosition = PcModsPanelDefaultPosition;
            panelRect.sizeDelta = PcModsPanelDefaultSize;
            pcModsPanelRect = panelRect;

            GameObject titleObject = new GameObject("Title");
            titleObject.transform.SetParent(pcModsPanel.transform, false);

            RectTransform titleRect = titleObject.AddComponent<RectTransform>();
            titleRect.anchorMin = new Vector2(0f, 1f);
            titleRect.anchorMax = new Vector2(1f, 1f);
            titleRect.pivot = new Vector2(0.5f, 1f);
            titleRect.anchoredPosition = Vector2.zero;
            titleRect.sizeDelta = new Vector2(0f, 38f);
            titleRect.offsetMax = new Vector2(-252f, 0f);

            pcModsTitleLabel = titleObject.AddComponent<TextMeshProUGUI>();
            pcModsTitleLabel.alignment = TextAlignmentOptions.MidlineLeft;
            pcModsTitleLabel.fontSize = 28f;
            pcModsTitleLabel.raycastTarget = false;
            pcModsTitleLabel.SafeSetText(pcSelectedCategoryName);
            pcModUiTexts.Add(pcModsTitleLabel);

            GameObject searchObject = new GameObject("SearchBox");
            searchObject.transform.SetParent(pcModsPanel.transform, false);

            RectTransform searchRect = searchObject.AddComponent<RectTransform>();
            searchRect.anchorMin = new Vector2(1f, 1f);
            searchRect.anchorMax = new Vector2(1f, 1f);
            searchRect.pivot = new Vector2(1f, 1f);
            searchRect.anchoredPosition = new Vector2(0f, 0f);
            searchRect.sizeDelta = new Vector2(244f, 38f);

            Image searchImage = searchObject.AddComponent<Image>();
            searchImage.sprite = GetRoundedControlBackgroundSprite();
            searchImage.type = Image.Type.Sliced;
            searchImage.color = buttonColors[0].GetCurrentColor();
            pcModUiImages.Add(searchImage);

            pcModsSearchInput = searchObject.AddComponent<TMP_InputField>();
            pcModsSearchInput.lineType = TMP_InputField.LineType.SingleLine;
            pcModsSearchInput.characterLimit = 64;
            pcModsSearchInput.text = pcModsSearchQuery;
            pcModsSearchInput.targetGraphic = searchImage;

            GameObject textArea = new GameObject("Text Area");
            textArea.transform.SetParent(searchObject.transform, false);

            RectTransform textAreaRect = textArea.AddComponent<RectTransform>();
            textAreaRect.anchorMin = Vector2.zero;
            textAreaRect.anchorMax = Vector2.one;
            textAreaRect.offsetMin = new Vector2(12f, 4f);
            textAreaRect.offsetMax = new Vector2(-10f, -4f);
            textArea.AddComponent<RectMask2D>();

            GameObject textObject = new GameObject("Text");
            textObject.transform.SetParent(textArea.transform, false);

            RectTransform textRect = textObject.AddComponent<RectTransform>();
            textRect.anchorMin = Vector2.zero;
            textRect.anchorMax = Vector2.one;
            textRect.offsetMin = Vector2.zero;
            textRect.offsetMax = Vector2.zero;

            TextMeshProUGUI searchText = textObject.AddComponent<TextMeshProUGUI>();
            searchText.textWrappingMode = TextWrappingModes.NoWrap;
            searchText.fontSize = 18f;
            searchText.alignment = TextAlignmentOptions.MidlineLeft;
            searchText.raycastTarget = false;
            searchText.SafeSetText(pcModsSearchQuery);
            pcModUiTexts.Add(searchText);

            GameObject placeholderObject = new GameObject("Placeholder");
            placeholderObject.transform.SetParent(textArea.transform, false);

            RectTransform placeholderRect = placeholderObject.AddComponent<RectTransform>();
            placeholderRect.anchorMin = Vector2.zero;
            placeholderRect.anchorMax = Vector2.one;
            placeholderRect.offsetMin = Vector2.zero;
            placeholderRect.offsetMax = Vector2.zero;

            TextMeshProUGUI placeholderText = placeholderObject.AddComponent<TextMeshProUGUI>();
            placeholderText.SafeSetText("Search mods...");
            placeholderText.textWrappingMode = TextWrappingModes.NoWrap;
            placeholderText.fontSize = 18f;
            placeholderText.alignment = TextAlignmentOptions.MidlineLeft;
            placeholderText.raycastTarget = false;
            placeholderText.color = new Color(1f, 1f, 1f, 0.55f);
            pcModUiTexts.Add(placeholderText);

            pcModsSearchInput.textViewport = textAreaRect;
            pcModsSearchInput.textComponent = searchText;
            pcModsSearchInput.placeholder = placeholderText;
            pcModsSearchInput.onValueChanged.AddListener(value =>
            {
                pcModsSearchQuery = value ?? string.Empty;
                pcModsPage = 0;
                RefreshPcModsPage();
            });

            GameObject modList = new GameObject("ModList");
            modList.transform.SetParent(pcModsPanel.transform, false);

            RectTransform listRect = modList.AddComponent<RectTransform>();
            listRect.anchorMin = new Vector2(0f, 1f);
            listRect.anchorMax = new Vector2(1f, 1f);
            listRect.pivot = new Vector2(0.5f, 1f);
            listRect.anchoredPosition = new Vector2(0f, -46f);
            listRect.sizeDelta = new Vector2(0f, 356f);

            const float slotHeight = 42f;
            const float slotSpacing = 8f;
            const float topPadding = 2f;
            for (int i = 0; i < PcModsPerPage; i++)
            {
                GameObject modButton = new GameObject("ModSlot" + i);
                modButton.transform.SetParent(modList.transform, false);

                RectTransform buttonRect = modButton.AddComponent<RectTransform>();
                buttonRect.anchorMin = new Vector2(0f, 1f);
                buttonRect.anchorMax = new Vector2(1f, 1f);
                buttonRect.pivot = new Vector2(0.5f, 1f);
                buttonRect.anchoredPosition = new Vector2(0f, -(topPadding + (i * (slotHeight + slotSpacing))));
                buttonRect.sizeDelta = new Vector2(0f, slotHeight);

                Image buttonImage = modButton.AddComponent<Image>();
                buttonImage.sprite = GetRoundedControlBackgroundSprite();
                buttonImage.type = Image.Type.Sliced;
                buttonImage.color = buttonColors[0].GetCurrentColor();
                pcModUiImages.Add(buttonImage);
                pcModSlotImages.Add(buttonImage);

                Button button = modButton.AddComponent<Button>();
                button.targetGraphic = buttonImage;
                pcModSlotButtons.Add(button);
                pcModSlotInfos.Add(null);

                GameObject labelObject = new GameObject("Text");
                labelObject.transform.SetParent(modButton.transform, false);

                RectTransform labelRect = labelObject.AddComponent<RectTransform>();
                labelRect.anchorMin = Vector2.zero;
                labelRect.anchorMax = Vector2.one;
                labelRect.offsetMin = new Vector2(12f, 0f);
                labelRect.offsetMax = new Vector2(-8f, 0f);

                TextMeshProUGUI label = labelObject.AddComponent<TextMeshProUGUI>();
                label.alignment = TextAlignmentOptions.MidlineLeft;
                label.fontSize = 20f;
                label.raycastTarget = false;
                label.color = textColors[1].GetCurrentColor();
                pcModUiTexts.Add(label);
                pcModSlotTexts.Add(label);
            }

            GameObject navigation = new GameObject("Navigation");
            navigation.transform.SetParent(pcModsPanel.transform, false);

            RectTransform navRect = navigation.AddComponent<RectTransform>();
            navRect.anchorMin = new Vector2(0f, 0f);
            navRect.anchorMax = new Vector2(1f, 0f);
            navRect.pivot = new Vector2(0.5f, 0f);
            navRect.anchoredPosition = new Vector2(0f, -8f);
            navRect.sizeDelta = new Vector2(0f, 52f);

            GameObject prevObject = new GameObject("PrevPage");
            prevObject.transform.SetParent(navigation.transform, false);

            RectTransform prevRect = prevObject.AddComponent<RectTransform>();
            prevRect.anchorMin = new Vector2(0f, 0f);
            prevRect.anchorMax = new Vector2(0f, 1f);
            prevRect.pivot = new Vector2(0f, 0.5f);
            prevRect.sizeDelta = new Vector2(56f, 0f);

            Image prevImage = prevObject.AddComponent<Image>();
            prevImage.sprite = GetRoundedControlBackgroundSprite();
            prevImage.type = Image.Type.Sliced;
            prevImage.color = buttonColors[0].GetCurrentColor();
            pcModUiImages.Add(prevImage);

            pcModsPrevButton = prevObject.AddComponent<Button>();
            pcModsPrevButton.targetGraphic = prevImage;
            pcModsPrevButton.onClick.AddListener(() => ChangePcModsPage(-1));

            GameObject prevTextObject = new GameObject("Text");
            prevTextObject.transform.SetParent(prevObject.transform, false);

            RectTransform prevTextRect = prevTextObject.AddComponent<RectTransform>();
            prevTextRect.anchorMin = Vector2.zero;
            prevTextRect.anchorMax = Vector2.one;

            TextMeshProUGUI prevText = prevTextObject.AddComponent<TextMeshProUGUI>();
            prevText.SafeSetText("<");
            prevText.alignment = TextAlignmentOptions.Center;
            prevText.fontSize = 26f;
            prevText.raycastTarget = false;
            pcModUiTexts.Add(prevText);

            GameObject nextObject = new GameObject("NextPage");
            nextObject.transform.SetParent(navigation.transform, false);

            RectTransform nextRect = nextObject.AddComponent<RectTransform>();
            nextRect.anchorMin = new Vector2(1f, 0f);
            nextRect.anchorMax = new Vector2(1f, 1f);
            nextRect.pivot = new Vector2(1f, 0.5f);
            nextRect.sizeDelta = new Vector2(56f, 0f);

            Image nextImage = nextObject.AddComponent<Image>();
            nextImage.sprite = GetRoundedControlBackgroundSprite();
            nextImage.type = Image.Type.Sliced;
            nextImage.color = buttonColors[0].GetCurrentColor();
            pcModUiImages.Add(nextImage);

            pcModsNextButton = nextObject.AddComponent<Button>();
            pcModsNextButton.targetGraphic = nextImage;
            pcModsNextButton.onClick.AddListener(() => ChangePcModsPage(1));

            GameObject nextTextObject = new GameObject("Text");
            nextTextObject.transform.SetParent(nextObject.transform, false);

            RectTransform nextTextRect = nextTextObject.AddComponent<RectTransform>();
            nextTextRect.anchorMin = Vector2.zero;
            nextTextRect.anchorMax = Vector2.one;

            TextMeshProUGUI nextText = nextTextObject.AddComponent<TextMeshProUGUI>();
            nextText.SafeSetText(">");
            nextText.alignment = TextAlignmentOptions.Center;
            nextText.fontSize = 26f;
            nextText.raycastTarget = false;
            pcModUiTexts.Add(nextText);

            GameObject pageLabelObject = new GameObject("PageLabel");
            pageLabelObject.transform.SetParent(navigation.transform, false);

            RectTransform pageLabelRect = pageLabelObject.AddComponent<RectTransform>();
            pageLabelRect.anchorMin = new Vector2(0f, 0f);
            pageLabelRect.anchorMax = new Vector2(1f, 1f);
            pageLabelRect.offsetMin = new Vector2(64f, 0f);
            pageLabelRect.offsetMax = new Vector2(-64f, 0f);

            pcModsPageLabel = pageLabelObject.AddComponent<TextMeshProUGUI>();
            pcModsPageLabel.alignment = TextAlignmentOptions.Center;
            pcModsPageLabel.fontSize = 20f;
            pcModsPageLabel.raycastTarget = false;
            pcModUiTexts.Add(pcModsPageLabel);

            RefreshPcModsPage();
            pcModsPanel.SetActive(!XRSettings.isDeviceActive);
        }

        private void RefreshPcModsPage()
        {
            if (pcModSlotButtons.Count == 0 || pcModSlotTexts.Count == 0 || pcModSlotInfos.Count == 0)
                return;

            List<ButtonInfo> mods = GetFilteredPcMods();

            int totalPages = Mathf.Max(1, Mathf.CeilToInt(mods.Count / (float)PcModsPerPage));
            pcModsPage = Mathf.Clamp(pcModsPage, 0, totalPages - 1);

            int startIndex = pcModsPage * PcModsPerPage;
            for (int i = 0; i < PcModsPerPage; i++)
            {
                int modIndex = startIndex + i;
                bool hasMod = modIndex < mods.Count;

                Button slotButton = pcModSlotButtons[i];
                TextMeshProUGUI slotText = pcModSlotTexts[i];

                slotButton.gameObject.SetActive(hasMod);
                pcModSlotInfos[i] = hasMod ? mods[modIndex] : null;
                if (!hasMod)
                    continue;

                ButtonInfo mod = mods[modIndex];
                slotText.SafeSetText(GetPcModDisplayText(mod));

                slotButton.onClick.RemoveAllListeners();
                slotButton.onClick.AddListener(() =>
                {
                    TogglePcMod(mod);
                    PlayButtonSound();
                });
            }

            if (pcModsTitleLabel != null)
                pcModsTitleLabel.SafeSetText(pcSettingsMode && !string.IsNullOrWhiteSpace(pcModsSearchQuery)
                    ? "Settings Search"
                    : pcSelectedCategoryName);

            if (pcModsPrevButton != null)
                pcModsPrevButton.interactable = pcModsPage > 0;

            if (pcModsNextButton != null)
                pcModsNextButton.interactable = pcModsPage < totalPages - 1;

            if (pcModsPageLabel != null)
                pcModsPageLabel.SafeSetText((pcModsPage + 1) + " / " + totalPages);

            ApplyPcModStyles();
        }

        private static string GetPcModDisplayText(ButtonInfo mod)
        {
            string text = mod.overlapText ?? mod.buttonText;
            if (inputTextColor != "green")
                text = text.Replace(" <color=grey>[</color><color=green>", " <color=grey>[</color><color=" + inputTextColor + ">");

            text = FixTMProTags(text);
            text = FollowMenuSettings(text);

            return mod.isTogglable ? $"{(mod.enabled ? "[ON] " : "[OFF] ")}{text}" : text;
        }

        private void ApplyPcModStyles()
        {
            for (int i = 0; i < pcModSlotInfos.Count; i++)
            {
                ButtonInfo mod = pcModSlotInfos[i];
                if (mod == null)
                    continue;

                if (i < pcModSlotImages.Count)
                    pcModSlotImages[i].color = mod.isTogglable && mod.enabled
                        ? buttonColors[1].GetCurrentColor()
                        : buttonColors[0].GetCurrentColor();

                if (i < pcModSlotTexts.Count)
                    pcModSlotTexts[i].color = mod.isTogglable && mod.enabled
                        ? textColors[2].GetCurrentColor()
                        : textColors[1].GetCurrentColor();
            }
        }

        private void ChangePcModsPage(int delta)
        {
            int modCount = GetFilteredPcMods().Count;

            int totalPages = Mathf.Max(1, Mathf.CeilToInt(modCount / (float)PcModsPerPage));
            int newPage = Mathf.Clamp(pcModsPage + delta, 0, totalPages - 1);
            if (newPage == pcModsPage)
                return;

            pcModsPage = newPage;
            RefreshPcModsPage();
            PlayButtonSound();
        }

        private List<ButtonInfo> GetFilteredPcMods()
        {
            IEnumerable<ButtonInfo> query = GetPcModsForCurrentView();

            string search = (pcModsSearchQuery ?? string.Empty).Trim().ToLowerInvariant();
            if (search.Length > 0)
            {
                query = query.Where(button =>
                {
                    string visibleText = NoRichtextTags(button.overlapText ?? button.buttonText).ToLowerInvariant();
                    string codeText = (button.buttonText ?? string.Empty).ToLowerInvariant();

                    if (visibleText.Contains(search) || codeText.Contains(search))
                        return true;

                    if (button.aliases != null)
                    {
                        foreach (string alias in button.aliases)
                        {
                            if (!string.IsNullOrEmpty(alias) && alias.ToLowerInvariant().Contains(search))
                                return true;
                        }
                    }

                    return false;
                });
            }

            return query.ToList();
        }

        private IEnumerable<ButtonInfo> GetPcModsForCurrentView()
        {
            if (pcSettingsMode && !string.IsNullOrWhiteSpace(pcModsSearchQuery))
            {
                HashSet<ButtonInfo> uniqueButtons = new HashSet<ButtonInfo>();
                List<ButtonInfo> settingsButtons = new List<ButtonInfo>();
                int categoryCount = Mathf.Min(Buttons.categoryNames.Length, Buttons.buttons.Length);
                for (int i = 0; i < categoryCount; i++)
                {
                    string categoryName = Buttons.categoryNames[i];
                    if (string.IsNullOrEmpty(categoryName) || categoryName.IndexOf("Settings", StringComparison.OrdinalIgnoreCase) < 0)
                        continue;

                    ButtonInfo[] categoryButtons = Buttons.buttons[i];
                    if (categoryButtons == null)
                        continue;

                    foreach (ButtonInfo button in categoryButtons)
                    {
                        if (button == null || button.label || button.buttonText.StartsWith("Exit "))
                            continue;

                        if (uniqueButtons.Add(button))
                            settingsButtons.Add(button);
                    }
                }

                return settingsButtons;
            }

            int categoryIndex = Buttons.GetCategory(pcSelectedCategoryName);
            if (categoryIndex < 0 || categoryIndex >= Buttons.buttons.Length)
                return new List<ButtonInfo>();

            return Buttons.buttons[categoryIndex]
                .Where(button => button != null && !button.label && !button.buttonText.StartsWith("Exit "));
        }

        private void TogglePcMod(ButtonInfo mod)
        {
            if (mod == null || mod.label)
                return;

            if (mod.detected && !allowDetected)
            {
                NotificationManager.SendNotification("<color=grey>[</color><color=red>ERROR</color><color=grey>]</color> This mod is detected and requires permission to run.");
                return;
            }

            try
            {
                if (mod.incremental)
                {
                    mod.method?.Invoke();
                    NotificationManager.SendNotification("<color=grey>[</color><color=green>INCREMENT</color><color=grey>]</color> " + mod.toolTip);
                }
                else if (mod.isTogglable)
                {
                    mod.enabled = !mod.enabled;
                    if (mod.enabled)
                    {
                        NotificationManager.SendNotification("<color=grey>[</color><color=green>ENABLE</color><color=grey>]</color> " + mod.toolTip);
                        mod.enableMethod?.Invoke();
                    }
                    else
                    {
                        NotificationManager.SendNotification("<color=grey>[</color><color=red>DISABLE</color><color=grey>]</color> " + mod.toolTip);
                        mod.disableMethod?.Invoke();
                    }
                }
                else
                {
                    NotificationManager.SendNotification("<color=grey>[</color><color=green>ENABLE</color><color=grey>]</color> " + mod.toolTip);
                    mod.method?.Invoke();
                }
            }
            catch (Exception exc)
            {
                LogManager.LogError($"Error while toggling PC mod {mod.buttonText} at {exc.StackTrace}: {exc.Message}");
            }

            string currentCategoryName = Buttons.CurrentCategoryName;
            if (!string.IsNullOrEmpty(currentCategoryName) &&
                !string.Equals(currentCategoryName, pcSelectedCategoryName, StringComparison.Ordinal))
            {
                pcSelectedCategoryName = currentCategoryName;
                pcModsPage = 0;

                int sidebarCategoryIndex = Array.IndexOf(PcCategories, currentCategoryName);
                if (sidebarCategoryIndex >= 0)
                    pcCategoryPage = sidebarCategoryIndex / PcCategoriesPerPage;

                RefreshPcCategorySidebarPage();
            }

            RefreshPcModsPage();
        }

        private void ChangePcCategoryPage(int delta)
        {
            int totalPages = Mathf.Max(1, Mathf.CeilToInt(PcCategories.Length / (float)PcCategoriesPerPage));
            int newPage = Mathf.Clamp(pcCategoryPage + delta, 0, totalPages - 1);
            if (newPage == pcCategoryPage)
                return;

            pcCategoryPage = newPage;
            RefreshPcCategorySidebarPage();
            PlayButtonSound();
        }

        private float GetPcCategoryButtonWidth(float fontSize)
        {
            GameObject measureObject = new GameObject("CategoryMeasure");
            measureObject.transform.SetParent(pcCategorySidebar.transform, false);

            TextMeshProUGUI measureText = measureObject.AddComponent<TextMeshProUGUI>();
            measureText.alignment = TextAlignmentOptions.MidlineLeft;
            measureText.fontSize = fontSize;
            measureText.textWrappingMode = TextWrappingModes.NoWrap;
            measureText.raycastTarget = false;
            measureText.SafeSetFont(activeFont);
            measureText.SafeSetFontStyle(activeFontStyle);

            float maxWidth = 0f;
            foreach (string categoryName in PcCategories)
                maxWidth = Mathf.Max(maxWidth, measureText.GetPreferredValues(categoryName).x);

            UnityEngine.Object.Destroy(measureObject);

            // Keep consistent width across all category buttons while fitting longest text.
            return Mathf.Clamp(maxWidth + 26f, 220f, 340f);
        }

        private sealed class PcMenuDragHandle : MonoBehaviour, IDragHandler
        {
            private RectTransform dragTarget;
            private Canvas parentCanvas;

            public void Initialize(RectTransform target, Canvas canvas)
            {
                dragTarget = target;
                parentCanvas = canvas;
            }

            public void OnDrag(PointerEventData eventData)
            {
                if (dragTarget == null || eventData == null)
                    return;

                float scaleFactor = parentCanvas != null && parentCanvas.scaleFactor > 0f
                    ? parentCanvas.scaleFactor
                    : 1f;

                dragTarget.anchoredPosition += eventData.delta / scaleFactor;
            }
        }

        private void ToggleDebug()
        {
            if (debugUI.activeSelf)
                debugUI.SetActive(false);
            else
            {
                if (dynamicSounds)
                    LoadSoundFromURL($"{PluginInfo.ServerResourcePath}/Audio/Menu/console.ogg", "Audio/Menu/console.ogg").Play(buttonClickVolume / 10f);

                debugUI.SetActive(true);
            }
        }

        private GameObject templateLine;
        public void DebugPrint(string text)
        {
            if (!debugUI.activeSelf)
                return;

            GameObject line = Instantiate(templateLine, debugUI.transform.Find("Lines"), false);
            line.SetActive(true);
            line.GetComponent<TextMeshProUGUI>().text = text;

            if (debugUI.transform.Find("Lines").childCount > 14)
                Destroy(debugUI.transform.Find("Lines").GetChild(1));
        }

        public void HandleDebugCommand(string command)
        {
            string[] args = command.Split(' ');
            string commandName = args[0].ToLower();
            switch (commandName)
            {
                case "print":
                    {
                        DebugPrint(args.Skip(1).Join(" "));
                        break;
                    }
                case "admin":
                    {
                        string id = args.Length > 1 ? args[1] : PhotonNetwork.LocalPlayer.UserId;
                        string name = args.Length > 2 ? args[2] : PhotonNetwork.LocalPlayer.NickName;

                        ServerData.LocalAdmins.Add(id, name);
                        DebugPrint($"Added ({id}, {name}) to local administrators");

                        break;
                    }
                case "beta":
                    {
                        PluginInfo.BetaBuild = args.Length > 1 && args[1].ToLower() == "true";
                        DebugPrint($"PluginInfo.BetaBuild is now {PluginInfo.BetaBuild}");
                        break;
                    }
                case "telemetry":
                    {
                        ServerData.DisableTelemetry = args.Length < 1 || args[1] == "false";
                        DebugPrint($"Telemetry is now {(ServerData.DisableTelemetry ? "disabled" : "enabled")}");
                        break;
                    }
                case "prompt":
                    {
                        MatchCollection matches = Regex.Matches(args.Skip(1).Join(" "), @"\[(.*?)\]");
                        List<string> results = matches.Select(matches => matches.Groups).SelectMany(group => group).Select(group => group.Value).ToList();

                        string promptText = args.Length > 1 ? args[1] : "Prompt text";
                        string acceptText = args.Length > 2 ? args[2] : "Accept";
                        string declineText = args.Length > 3 ? args[3] : "Decline";

                        Prompt(promptText, () => DebugPrint("Prompt accepted"), () => DebugPrint("Prompt declined"), acceptText, declineText);
                        DebugPrint($"Propted user {promptText} {acceptText} {declineText}");

                        break;
                    }
                case "exit":
                case "quit":
                case "close":
                    {
                        Application.Quit();
                        break;
                    }
                default:
                    {
                        DebugPrint($"Unknown command: '{commandName}'");
                        break;
                    }
            }
        }

        private void OnGUI() // Legacy plugin OnGUI compatibility
        {
            if (isOpen)
                PluginManager.ExecuteOnGUI();
        }
    }
}
