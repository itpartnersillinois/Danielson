﻿using Danielson.Data.DataAccess;
using Microsoft.AspNetCore.Components;

namespace Danielson.Components.Controls {

    public partial class FormHeader {

        [Parameter]
        public int FormId { get; set; }

        [Parameter]
        public bool IsMidterm { get; set; }

        [Parameter]
        public EventCallback<bool> OnChangeCallback { get; set; }

        [Inject]
        private FormAccess FormAccess { get; set; } = default!;

        protected async Task SaveChange(bool isMidterm) {
            var form = await FormAccess.GetForm(FormId);
            form.IsMidterm = isMidterm;
            _ = await FormAccess.Save(form);
            await OnChangeCallback.InvokeAsync(isMidterm);
        }
    }
}