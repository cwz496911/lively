﻿using System;
using System.Collections.Generic;
using System.Text;
using livelywpf.Helpers;

namespace livelywpf
{
    public class HelpViewModel : ObservableObject
    {
        //public bool IsWinStore => Program.IsMSIX;

        private RelayCommand _websiteCommand;
        public RelayCommand WebsiteCommand
        {
            get
            {
                if (_websiteCommand == null)
                {
                    _websiteCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://livelywallpaper.net/"));
                }
                return _websiteCommand;
            }
        }

        private RelayCommand _documentationCommand;
        public RelayCommand DocumentationCommand
        {
            get
            {
                if (_documentationCommand == null)
                {
                    _documentationCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://github.com/rocksdanister/lively/wiki"));
                }
                return _documentationCommand;
            }
        }

        private RelayCommand _communityCommand;
        public RelayCommand CommunityCommand
        {
            get
            {
                if (_communityCommand == null)
                {
                    _communityCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://www.reddit.com/r/LivelyWallpaper/"));
                }
                return _communityCommand;
            }
        }

        private RelayCommand _bugReportCommand;
        public RelayCommand BugReportCommand
        {
            get
            {
                if (_bugReportCommand == null)
                {
                    _bugReportCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://github.com/rocksdanister/lively/issues"));
                }
                return _bugReportCommand;
            }
        }

        private RelayCommand _sourceCodeCommand;
        public RelayCommand SourceCodeCommand
        {
            get
            {
                if (_sourceCodeCommand == null)
                {
                    _sourceCodeCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://github.com/rocksdanister/lively/"));
                }
                return _sourceCodeCommand;
            }
        }

        private RelayCommand _supportCommand;
        public RelayCommand SupportCommand
        {
            get
            {
                if (_supportCommand == null)
                {
                    _supportCommand = new RelayCommand(
                        param => LinkHandler.OpenBrowser("https://ko-fi.com/rocksdanister"));
                }
                return _supportCommand;
            }
        }
    }
}
