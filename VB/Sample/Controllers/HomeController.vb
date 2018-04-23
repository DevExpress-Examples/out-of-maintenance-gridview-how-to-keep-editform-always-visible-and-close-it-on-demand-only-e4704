Imports Microsoft.VisualBasic
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports Sample.Models

Namespace Sample.Controllers
	Public Class HomeController
		Inherits Controller
		Private list As New PersonsList()

		Public Function Index() As ActionResult
			Return View(list.GetPersons())
		End Function

		Public Function GridViewEditingPartial() As ActionResult
			Return PartialView(list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)> _
		Public Function EditingAddNew(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal person As Person, ByVal keepOpened As Boolean) As ActionResult
			If ModelState.IsValid Then
				list.AddPerson(person)
			End If

			ViewData("KeepOpened") = keepOpened
			ViewData("EditingRowKey") = person.PersonID
			Return PartialView("GridViewEditingPartial", list.GetPersons())
		End Function

		<HttpPost, ValidateInput(False)> _
		Public Function EditingUpdate(<ModelBinder(GetType(DevExpressEditorsBinder))> ByVal personInfo As Person, ByVal keepOpened As Boolean) As ActionResult
			If ModelState.IsValid Then
				list.UpdatePerson(personInfo)
			End If

			ViewData("KeepOpened") = keepOpened
			ViewData("EditingRowKey") = personInfo.PersonID
			Return PartialView("GridViewEditingPartial", list.GetPersons())
		End Function

		Public Function EditingDelete(ByVal personId As Integer) As ActionResult
			list.DeletePerson(personId)
			Return PartialView("GridViewEditingPartial", list.GetPersons())
		End Function
	End Class
End Namespace