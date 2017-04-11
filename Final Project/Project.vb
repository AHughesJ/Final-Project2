Option Strict On
Option Explicit On

Public Class Project

    Private mID As Integer
    Private mName As String
    Private mInitialCFO As Double
    Private mDiscountRate As Decimal
    Private mCfPeriods As Integer
    Private mNPV As Double          'CfAccumulator
    Private mDescription As String


    Public Sub New(ByVal pID As Integer, ByVal pName As String,
                    ByVal pInitialCFO As Double, ByVal pDiscountRate As Decimal, ByVal pCfPeriods As Integer,
                   ByVal pNPV As Double, Optional ByVal pDescription As String = "")

        mID = pID
        mName = pName
        mInitialCFO = pInitialCFO
        mDiscountRate = pDiscountRate
        mCfPeriods = pCfPeriods
        mNPV = pNPV
        mDescription = pDescription

    End Sub

End Class
