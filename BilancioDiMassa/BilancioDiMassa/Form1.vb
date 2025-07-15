Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEseguiReport.Click

        ' cancello file .data del Report SSRS onde evitare cache dei dati
        Dim fileData_SSRS As String = "\\logman\CED\Business Intelligence\Report Sharepoint Sql 2008R2\Report Project1\BilancioDiMassa.rdl.data"
        If System.IO.File.Exists(fileData_SSRS) Then
            System.IO.File.Delete(fileData_SSRS)
        End If

        If (TextBoxCodiceArticoloMPA.Text = "") Then
            MessageBox.Show("VALORIZZARE IL CODICE ARTICOLO", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (TextBoxLotto.Text = "") Then
            MessageBox.Show("VALORIZZARE IL LOTTO", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Application.UseWaitCursor = True

        Dim conn1 As SqlConnection = New SqlConnection("Data Source=jdedbsrv;Initial Catalog=JDE_PRODUCTION;User ID=sa;Password=jdemgr")
        Dim cmd_exec As SqlCommand = New SqlCommand("exec dbo.BilancioDiMassa_P '" & TextBoxCodiceArticoloMPA.Text & "','" & TextBoxLotto.Text.Trim & "','" & DateTimePicker_DataDA.Value.ToString("yyyyMMdd") & "','" & DateTimePicker_DataA.Value.ToString("yyyyMMdd") & "'", conn1)
        conn1.Open()
        cmd_exec.CommandType = CommandType.Text
        cmd_exec.CommandTimeout = 0 ' attendo l'esecuzione della stored
        cmd_exec.ExecuteNonQuery()
        conn1.Close()

        Threading.Thread.Sleep(2000)

        MessageBox.Show("Elaborazione terminata!" & vbCrLf & "Attendere la finestra di salvataggio dell'Excel poi salvare.", "ELABORAZIONE OK", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Dim fileOutput As String = ""
        If (ComboBoxFormatoFile.Text = "EXCEL (.xls)") Then
            fileOutput = "&rs:Format=EXCEL"
        ElseIf (ComboBoxFormatoFile.Text = "CSV (.csv)") Then
            fileOutput = "&rs:Format=CSV"
        ElseIf (ComboBoxFormatoFile.Text = "PDF (.pdf)") Then
            fileOutput = "&rs:Format=PDF"
        ElseIf (ComboBoxFormatoFile.Text = "XML (.xml)") Then
            fileOutput = "&rs:Format=XML"
        ElseIf (ComboBoxFormatoFile.Text = "WORD (.doc)") Then
            fileOutput = "&rs:Format=WORD"
        ElseIf (ComboBoxFormatoFile.Text = "WEB (visualizza nel browser)") Then
            fileOutput = ""
        End If

        Process.Start("http://webportal/quality/_vti_bin/ReportServer/?http%3a%2f%2fwebportal%2fquality%2fReport+JDE%2fBilancioDiMassa.rdl&rs:ClearSession=true&rc:Toolbar=false&rs:Command=Render" & fileOutput).WaitForExit()

        TextBoxLotto.Text = ""

        Application.UseWaitCursor = False
        Return
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonVisualizzaLotti.Click
        If (TextBoxCodiceArticoloMPA.Text = "") Then
            MessageBox.Show("VALORIZZARE IL CODICE ARTICOLO", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim conn_DW As SqlConnection = New SqlConnection("Data Source=jdedbsrv;Initial Catalog=DWFelsineoE900;User ID=sa;Password=jdemgr")
        conn_DW.Open()
        Dim dataAdapter As New SqlDataAdapter("select distinct CodArticolo,DescArticolo,Lotto,jde_production.dbo.JulianToDate(DataAcquisto) as DataAcquisto,NumOrdine,Fornitore,OrdineFornitore from dbo.BilancioDiMassa_Vista_per_Acquisti_dal_2014_V where CodArticolo = '" & TextBoxCodiceArticoloMPA.Text.Trim & "' and DataAcquisto between jde_production.dbo.DateToJulian('" & DateTimePicker_DataDA.Value.ToString("yyyyMMdd") & "') and  jde_production.dbo.DateToJulian('" & DateTimePicker_DataA.Value.ToString("yyyyMMdd") & "')", conn_DW)
        Dim ds As New DataSet()
        Dim table As New DataTable
        dataAdapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

End Class
