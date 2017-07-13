VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00FF0000&
   Caption         =   "Ureal Gold launcher by echo_03"
   ClientHeight    =   5775
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7665
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   Picture         =   "Form1.frx":08CA
   ScaleHeight     =   5775
   ScaleWidth      =   7665
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      BackColor       =   &H8000000D&
      Caption         =   "PLAY!!!"
      Height          =   615
      Left            =   5400
      TabIndex        =   4
      Top             =   1440
      Width           =   1815
   End
   Begin VB.TextBox botnum 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1032
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Left            =   1080
      TabIndex        =   2
      Top             =   1800
      Width           =   975
   End
   Begin VB.FileListBox File1 
      Appearance      =   0  'Flat
      ForeColor       =   &H80000007&
      Height          =   810
      Left            =   1800
      TabIndex        =   0
      Top             =   4920
      Width           =   5175
   End
   Begin VB.Label Label2 
      BackColor       =   &H00808080&
      Caption         =   "bot number"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   720
      TabIndex        =   3
      Top             =   1200
      Width           =   1695
   End
   Begin VB.Label Label1 
      BackColor       =   &H00808080&
      Caption         =   "choose map"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   600
      TabIndex        =   1
      Top             =   4920
      Width           =   1215
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Kill "batch.bat"
nfile = FreeFile
Open CurDir + "\batch.BAT" For Append As nfile
Print #nfile, "system\unreal.exe " + File1.FileName + "?spectatoronly=false?numbots=" + botnum.Text + "?quickstart=true"
Close nfile
Shell "batch.bat"
End Sub
Private Sub Form_Load()
File1.Path = CurDir + "\maps"
End Sub
