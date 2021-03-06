﻿Imports DevExpress.Web.Localization
Imports DevExpress.Utils.Localization.Internal

Namespace CustomLocalizer

    Public Class MyGridLocalizer
        Inherits ASPxGridViewLocalizer

        Public Shared Sub Activate()
            Dim localizer As New MyGridLocalizer()
            Dim provider As DefaultActiveLocalizerProvider(Of ASPxGridViewStringId) = _
                New DefaultActiveLocalizerProvider(Of ASPxGridViewStringId)(localizer)
            MyGridLocalizer.SetActiveLocalizerProvider(provider)
        End Sub

        Public Overrides Function GetLocalizedString(ByVal id As ASPxGridViewStringId) As String
            If id = ASPxGridViewStringId.GroupPanel Then
                Return "Testing: group panel caption"
            End If
            Dim result As String = MyBase.GetLocalizedString(id)
            Return String.Format("grid:{0}", result)
        End Function

    End Class

End Namespace
