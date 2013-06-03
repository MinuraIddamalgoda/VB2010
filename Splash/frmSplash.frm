VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmSplash 
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   1725
   ClientLeft      =   255
   ClientTop       =   1410
   ClientWidth     =   5565
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Icon            =   "frmSplash.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MousePointer    =   99  'Custom
   ScaleHeight     =   1725
   ScaleWidth      =   5565
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer3 
      Interval        =   100
      Left            =   3480
      Top             =   120
   End
   Begin VB.Timer Timer2 
      Interval        =   1000
      Left            =   4320
      Top             =   120
   End
   Begin VB.Frame Frame2 
      Caption         =   "The System will terminate in 60 Seconds."
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   5295
      Begin MSComctlLib.ProgressBar ProgressBar1 
         Height          =   285
         Left            =   240
         TabIndex        =   1
         Top             =   360
         Width           =   4935
         _ExtentX        =   8705
         _ExtentY        =   503
         _Version        =   393216
         BorderStyle     =   1
         Appearance      =   0
         Min             =   2
         Max             =   552
         Scrolling       =   1
      End
   End
   Begin VB.Label Label1 
      Caption         =   "Press ESC to exit"
      Height          =   255
      Left            =   240
      TabIndex        =   2
      Top             =   120
      Width           =   1455
   End
End
Attribute VB_Name = "frmSplash"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim p%, s%

Private Sub Form_KeyPress(KeyAscii As Integer)
  If KeyAscii = 27 Then
    End
  End If
End Sub

Private Sub Form_Load()
  p = p + 1
  'initialize timer2
  s = 59
End Sub

Private Sub Timer1_Timer()
  lblDate.Caption = Format(Date, "mmmm dd, yyyy")
  lblTime.Caption = Format(Time, "hh:mm:ss AM/PM")
End Sub

Private Sub Timer2_Timer()
Frame2.Caption = "Program will terminate in " & s & " seconds."
s = s - 1
End Sub

Private Sub Timer3_Timer()
  ProgressBar1.Value = ProgressBar1.Value + 1
  If ProgressBar1.Value = 552 Then
    MsgBox "Sorry Your time is up!", vbCritical, "Login"
    p = p - 1
  End
  End If
End Sub
