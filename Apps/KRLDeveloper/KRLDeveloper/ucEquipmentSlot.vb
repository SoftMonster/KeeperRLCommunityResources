Public Class ucEquipmentSlot
    Public Overrides Property Text As String
        Set(value As String)
            ComboBox1.Text = value
        End Set
        Get
            Return ComboBox1.Text
        End Get
    End Property

End Class
