Public Class codeQRProcess
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Public Function createCode(Text As String)
        Return QR_Generator.Encode(Text)
    End Function
End Class
