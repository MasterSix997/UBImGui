using System;
using System.Collections;
using System.Collections.Generic;
using ImGuiNET;
using UnityEngine;

public class SimpleConsole : MonoBehaviour
{
    private string _inputText = "";
    private uint _maxInputSize = 200;
    private List<string> _logItems = new List<string>();
    private Dictionary<string, Action> _commands = new Dictionary<string, Action>();

    //Scroll To bottom flag
    private bool _scrollToBottom;
    //Keeping scrolling on add new input
    private bool _autoScroll = true;

    private void Start()
    {
        _commands.Add("help", () => AddLog("do 'all-commands' for view commands available"));
        _commands.Add("clear", ClearLog);
        _commands.Add("all-commands", () =>
        {
            foreach (var command in _commands.Keys)
            {
                AddLog(string.Concat(" - ", command));
            }
        });
        _commands.Add("add-log", () => AddLog("Some sample log message."));
        _commands.Add("add-error", () => AddLog("[ERROR]: Something wrong is not right!"));
        _commands.Add("add-info", () => AddLog("[INFO]: Simple information for you :D"));
        
        ClearLog();
        AddLog("Initializing Console!");
    }

    private void OnEnable() => ImGui.Layout += OnLayout;
    private void OnDisable() => ImGui.Layout -= OnLayout;

    public void AddLog(string log)
    {
        _logItems.Add(log);
    }

    public void ClearLog()
    {
        _logItems.Clear();
    }

    public void ExecuteCommand(string command)
    {
        if (_commands.TryGetValue(command, out var action))
        {
            action.Invoke();
        }
        else
        {
            AddLog("[ERROR]: Invalid Command!!");
        }
    }
    
    private void OnLayout()
    {
        ImGui.SetNextWindowSize(new Vector2(520, 600), ImGuiCond.FirstUseEver);
        if (!ImGui.Begin("Console"))
        {
            ImGui.End();
            return;
        }
        
        var footerHeightToReserve = ImGui.GetStyle().ItemSpacing.y + ImGui.GetFrameHeightWithSpacing();
        if (ImGui.BeginChild("ScrollingRegion", new Vector2(0, -footerHeightToReserve), ImGuiChildFlags.NavFlattened, ImGuiWindowFlags.HorizontalScrollbar))
        {
            foreach (var logItem in _logItems)
            {
                var hasColor = false;
                var color = Color.white;
                if (logItem.StartsWith("[ERROR]"))
                {
                    hasColor = true;
                    color = Color.red;
                }
                else if (logItem.StartsWith("[INFO]"))
                {
                    hasColor = true;
                    color = Color.green;
                }

                if (hasColor) ImGui.PushStyleColor(ImGuiCol.Text, color);
                ImGui.TextUnformatted(logItem);
                if (hasColor) ImGui.PopStyleColor();
            }
            
            if (_scrollToBottom || (_autoScroll && ImGui.GetScrollY() >= ImGui.GetScrollMaxY()))
                ImGui.SetScrollY(1.0f);

            _scrollToBottom = false;
        }
        ImGui.EndChild();
        ImGui.Separator();

        var reclaimFocus = false;
        var inputTextFlags = ImGuiInputTextFlags.EnterReturnsTrue | ImGuiInputTextFlags.EscapeClearsAll;
        if (ImGui.InputText("Input", ref _inputText, _maxInputSize, inputTextFlags))
        {
            var inputProcessed = _inputText.Trim().ToLower();
            if (inputProcessed.Length > 0)
            {
                AddLog("> " + inputProcessed);
                ExecuteCommand(inputProcessed);
            }

            _inputText = "";
            reclaimFocus = true;
        }
        
        ImGui.SetItemDefaultFocus();
        if (reclaimFocus)
            ImGui.SetKeyboardFocusHere(-1);
        
        ImGui.End();
    }
}
