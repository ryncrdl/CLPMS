Imports System.Web.UI.WebControls

Module SwitchingPanels
    Public Function SwitchPanel(panel, panelName)
        With panelName
            .TopLevel = False
            panel.Controls.Add(panelName)
            .BringToFront()
            .Show()
        End With
    End Function
End Module
