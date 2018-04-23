@ModelType List(Of Sample.Models.Person)
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
            settings.KeyFieldName = "PersonID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewEditingPartial"}

            settings.SettingsEditing.Mode = GridViewEditingMode.EditFormAndDisplayRow
            settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "EditingAddNew"}
            settings.SettingsEditing.UpdateRowRouteValues = New With {.Controller = "Home", .Action = "EditingUpdate"}
            settings.SettingsEditing.DeleteRowRouteValues = New With {.Controller = "Home", .Action = "EditingDelete"}

            settings.CommandColumn.Visible = True
            settings.CommandColumn.NewButton.Visible = True
            settings.CommandColumn.DeleteButton.Visible = True
            settings.CommandColumn.EditButton.Visible = True

            settings.Columns.Add("FirstName")
            settings.Columns.Add("MiddleName")
            settings.Columns.Add("LastName")

            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
            settings.BeforeGetCallbackResult = _
                Sub(sender, e)
                        If ViewData("KeepOpened") IsNot Nothing Then
                            Dim keepOpened As Boolean = Convert.ToBoolean(ViewData("KeepOpened"))
                            If keepOpened Then
                                Dim grid As MVCxGridView = CType(sender, MVCxGridView)

                                Dim keyValue As Object = ViewData("EditingRowKey")
                                Dim visibleIndex As Integer = grid.FindVisibleIndexByKeyValue(keyValue)

                                grid.StartEdit(visibleIndex)
                            End If
                        End If
                End Sub
    End Sub).Bind(Model).GetHtml()