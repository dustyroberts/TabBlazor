﻿using Microsoft.AspNetCore.Components;
using NGageUI.Components.Tables;

namespace NGageUI.Components.Tables
{
    public class TableHeaderToolsBase<TableItem> : ComponentBase
    {
        [CascadingParameter(Name = "Table")] public ITable<TableItem> Table { get; set; }

    }
}