Public Class Class1
    Private Property a As Int32
    Private Property b As String
    Protected Property c As Int32
    Protected Property d As Boolean
    Public Property e As Single
    Public Property f As Single
    Public Function Sum() As Single
        Return Me.e + Me.f
    End Function
    Public Function Sum(ByVal a1 As Single) As Single
        Return Me.e + Me.f + a1
    End Function
    Public Function Sum(ByVal a1 As Single, ByVal a2 As Single) As Single
        Return Me.e + Me.f + a1 + a2
    End Function
    Public Function Sum(ByVal a1 As Single, ByVal a2 As Single, ByVal a3 As Single) As Single
        'Dim t = Sum(a1, a2)
        't = t + a3
        'Return t
        Return Sum(a1, a2) + a3
    End Function
    Public Function Mult() As Single
        Return Me.e * Me.f
    End Function
    Public Function factor(ByVal f As Single) As Single
        Return (Me.e + Me.f) * f
    End Function

    'Create a constructor
    Public Sub New()
        a = 6
        c = 4
        b = String.Format("Your age ={0}, salary={1}", a, a * 11000)
    End Sub

End Class
