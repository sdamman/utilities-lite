﻿using System;
using System.Windows;

namespace ALMACO.UI
{
  public sealed class ThemeResourceExtension : DynamicResourceExtension
    {
        public new ThemeResourceKey ResourceKey
        {
            get
            {
                Enum.TryParse(base.ResourceKey.ToString(), out ThemeResourceKey resourceKey);
                return resourceKey;
            }
            set
            {
                base.ResourceKey = value.ToString();
            }
        }
    }
}
