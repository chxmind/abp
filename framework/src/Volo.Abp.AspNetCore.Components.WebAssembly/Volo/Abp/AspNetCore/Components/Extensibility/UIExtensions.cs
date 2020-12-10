﻿using Volo.Abp.AspNetCore.Components.Extensibility.EntityActions;
using Volo.Abp.AspNetCore.Components.Extensibility.TableColumns;

namespace Volo.Abp.AspNetCore.Components.Extensibility
{
    public class UIExtensions
    {
        public static UIExtensions Instance { get; protected set; } = new UIExtensions();

        public EntityActionsConfiguration EntityActions { get; set; }

        public TableColumnsConfiguration TableColumns { get; set; }

        public UIExtensions()
        {
            EntityActions = new EntityActionsConfiguration();
            TableColumns = new TableColumnsConfiguration();
        }
    }
}
