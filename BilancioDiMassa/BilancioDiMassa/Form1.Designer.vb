<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxCodiceArticoloMPA = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_DataDA = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_DataA = New System.Windows.Forms.DateTimePicker()
        Me.LabelCodiceArticolo = New System.Windows.Forms.Label()
        Me.LabelDataDA = New System.Windows.Forms.Label()
        Me.LabelDataA = New System.Windows.Forms.Label()
        Me.TextBoxLotto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBoxFormatoFile = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonVisualizzaLotti = New System.Windows.Forms.Button()
        Me.ButtonEseguiReport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCodiceArticoloMPA
        '
        Me.TextBoxCodiceArticoloMPA.Location = New System.Drawing.Point(167, 22)
        Me.TextBoxCodiceArticoloMPA.Name = "TextBoxCodiceArticoloMPA"
        Me.TextBoxCodiceArticoloMPA.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCodiceArticoloMPA.TabIndex = 1
        Me.TextBoxCodiceArticoloMPA.Text = "ARAPISBR"
        '
        'DateTimePicker_DataDA
        '
        Me.DateTimePicker_DataDA.Location = New System.Drawing.Point(167, 48)
        Me.DateTimePicker_DataDA.Name = "DateTimePicker_DataDA"
        Me.DateTimePicker_DataDA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_DataDA.TabIndex = 2
        Me.DateTimePicker_DataDA.Value = New Date(2017, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker_DataA
        '
        Me.DateTimePicker_DataA.Location = New System.Drawing.Point(167, 74)
        Me.DateTimePicker_DataA.Name = "DateTimePicker_DataA"
        Me.DateTimePicker_DataA.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker_DataA.TabIndex = 3
        '
        'LabelCodiceArticolo
        '
        Me.LabelCodiceArticolo.AutoSize = True
        Me.LabelCodiceArticolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodiceArticolo.Location = New System.Drawing.Point(16, 29)
        Me.LabelCodiceArticolo.Name = "LabelCodiceArticolo"
        Me.LabelCodiceArticolo.Size = New System.Drawing.Size(123, 13)
        Me.LabelCodiceArticolo.TabIndex = 4
        Me.LabelCodiceArticolo.Text = "Codice Articolo MPA"
        '
        'LabelDataDA
        '
        Me.LabelDataDA.AutoSize = True
        Me.LabelDataDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataDA.Location = New System.Drawing.Point(15, 55)
        Me.LabelDataDA.Name = "LabelDataDA"
        Me.LabelDataDA.Size = New System.Drawing.Size(107, 13)
        Me.LabelDataDA.TabIndex = 5
        Me.LabelDataDA.Text = "Data acquisto DA"
        '
        'LabelDataA
        '
        Me.LabelDataA.AutoSize = True
        Me.LabelDataA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDataA.Location = New System.Drawing.Point(15, 80)
        Me.LabelDataA.Name = "LabelDataA"
        Me.LabelDataA.Size = New System.Drawing.Size(98, 13)
        Me.LabelDataA.TabIndex = 6
        Me.LabelDataA.Text = "Data acquisto A"
        '
        'TextBoxLotto
        '
        Me.TextBoxLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLotto.Location = New System.Drawing.Point(316, 293)
        Me.TextBoxLotto.Name = "TextBoxLotto"
        Me.TextBoxLotto.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxLotto.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lotto"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(15, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(501, 177)
        Me.DataGridView1.TabIndex = 10
        '
        'ComboBoxFormatoFile
        '
        Me.ComboBoxFormatoFile.FormattingEnabled = True
        Me.ComboBoxFormatoFile.Items.AddRange(New Object() {"EXCEL (.xls)", "CSV (.csv)", "PDF (.pdf)", "XML (.xml)", "WORD (.doc)", "WEB (visualizza nel browser)"})
        Me.ComboBoxFormatoFile.Location = New System.Drawing.Point(316, 323)
        Me.ComboBoxFormatoFile.Name = "ComboBoxFormatoFile"
        Me.ComboBoxFormatoFile.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxFormatoFile.TabIndex = 14
        Me.ComboBoxFormatoFile.Text = "EXCEL (.xls)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Formato Output"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BilancioDiMassa.My.Resources.Resources.logo_small
        Me.PictureBox2.Location = New System.Drawing.Point(522, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BilancioDiMassa.My.Resources.Resources.pork
        Me.PictureBox1.Location = New System.Drawing.Point(522, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Image = Global.BilancioDiMassa.My.Resources.Resources.fire_exit
        Me.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonExit.Location = New System.Drawing.Point(15, 283)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(98, 66)
        Me.ButtonExit.TabIndex = 11
        Me.ButtonExit.Text = "Chiudi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "App"
        Me.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonVisualizzaLotti
        '
        Me.ButtonVisualizzaLotti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonVisualizzaLotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVisualizzaLotti.Image = Global.BilancioDiMassa.My.Resources.Resources.lente
        Me.ButtonVisualizzaLotti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonVisualizzaLotti.Location = New System.Drawing.Point(414, 22)
        Me.ButtonVisualizzaLotti.Name = "ButtonVisualizzaLotti"
        Me.ButtonVisualizzaLotti.Size = New System.Drawing.Size(102, 72)
        Me.ButtonVisualizzaLotti.TabIndex = 7
        Me.ButtonVisualizzaLotti.Text = "Visualizza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lotti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Acquistati"
        Me.ButtonVisualizzaLotti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonVisualizzaLotti.UseVisualStyleBackColor = True
        '
        'ButtonEseguiReport
        '
        Me.ButtonEseguiReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEseguiReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEseguiReport.Image = Global.BilancioDiMassa.My.Resources.Resources.bilancioMassa
        Me.ButtonEseguiReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEseguiReport.Location = New System.Drawing.Point(522, 283)
        Me.ButtonEseguiReport.Name = "ButtonEseguiReport"
        Me.ButtonEseguiReport.Size = New System.Drawing.Size(90, 66)
        Me.ButtonEseguiReport.TabIndex = 0
        Me.ButtonEseguiReport.Text = "Esporta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report"
        Me.ButtonEseguiReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEseguiReport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxFormatoFile)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxLotto)
        Me.Controls.Add(Me.ButtonVisualizzaLotti)
        Me.Controls.Add(Me.LabelDataA)
        Me.Controls.Add(Me.LabelDataDA)
        Me.Controls.Add(Me.LabelCodiceArticolo)
        Me.Controls.Add(Me.DateTimePicker_DataA)
        Me.Controls.Add(Me.DateTimePicker_DataDA)
        Me.Controls.Add(Me.TextBoxCodiceArticoloMPA)
        Me.Controls.Add(Me.ButtonEseguiReport)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bilancio di Massa MPA - Felsineo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEseguiReport As Button
    Friend WithEvents TextBoxCodiceArticoloMPA As TextBox
    Friend WithEvents DateTimePicker_DataDA As DateTimePicker
    Friend WithEvents DateTimePicker_DataA As DateTimePicker
    Friend WithEvents LabelCodiceArticolo As Label
    Friend WithEvents LabelDataDA As Label
    Friend WithEvents LabelDataA As Label
    Friend WithEvents ButtonVisualizzaLotti As Button
    Friend WithEvents TextBoxLotto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBoxFormatoFile As ComboBox
    Friend WithEvents Label2 As Label
End Class
