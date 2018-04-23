@ModelType List(Of Sample.Models.Person)
    
<script type="text/javascript">
    function OnBeginCallback(s, e) {
        e.customArgs["KeepOpened"] = cbKeepOpened.GetChecked();
    }
</script>

@Html.DevExpress().CheckBox( _
    Sub(settings)
            settings.Name = "cbKeepOpened"
            settings.Checked = True
            settings.Text = "Keep Edit Form Opened?"
    End Sub).GetHtml()

@Html.Partial("GridViewEditingPartial", Model)