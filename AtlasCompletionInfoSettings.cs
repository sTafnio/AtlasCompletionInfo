﻿using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace AtlasCompletionInfo;

public class AtlasCompletionInfoSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    [Menu("Show Maps on Atlas screen")]
    public ToggleNode ShowMapsOnAtlas { get; set; } = new ToggleNode(false);
    [Menu("Copy uncompleted Maps")]
    public ButtonNode Copy { get; set; } = new ButtonNode();
    [Menu("Hotkey to Copy:")]
    public HotkeyNode CopyHotkey { get; set; } = Keys.None;
}