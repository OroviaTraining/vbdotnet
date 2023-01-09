Public Class Product

    Public Enum PROD_CATG
        COMPUTER = 1
        FURNITURE = 2
        METALS = 3
        TOOLS = 4
    End Enum

    Public Property PID As Byte
    Public Property PCatg As PROD_CATG
    Public Property PCost As Decimal
    Public Property PName As String


End Class
