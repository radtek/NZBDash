﻿#region Copyright
//  ***********************************************************************
//  Copyright (c) 2015 Jamie Rees
//  File: BaseSettingsViewModel.cs
//  Created By: Jamie Rees
//
//  Permission is hereby granted, free of charge, to any person obtaining
//  a copy of this software and associated documentation files (the
//  "Software"), to deal in the Software without restriction, including
//  without limitation the rights to use, copy, modify, merge, publish,
//  distribute, sublicense, and/or sell copies of the Software, and to
//  permit persons to whom the Software is furnished to do so, subject to
//  the following conditions:
//
//  The above copyright notice and this permission notice shall be
//  included in all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//  EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//  MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//  LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//  OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//  WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ***********************************************************************
#endregion
using System;
using System.ComponentModel.DataAnnotations;

using NZBDash.Common.Helpers;
using NZBDash.UI.Helpers;

namespace NZBDash.UI.Models.Settings
{
    public class BaseSettingsViewModel
    {
        public int Id { get; set; }
        public bool Enabled { get; set; }
        [Display(Name = "Settings_ShowOnDashboard", ResourceType = typeof(Resources.Resources))]
        public bool ShowOnDashboard { get; set; }
        [Required]
        [Display(Name = "Settings_IpAddress", ResourceType = typeof(Resources.Resources))]
        public string IpAddress { get; set; }
        [Required]
        [Display(Name = "Settings_Port", ResourceType = typeof(Resources.Resources))]
        public int Port { get; set; }

        public Uri FullUri
        {
            get
            {
                return UrlHelper.ReturnUri(IpAddress, Port);
            }
        }
    }
}