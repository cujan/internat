Public Class student

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: Tento řádek načte data do tabulky 'InternatDataSet.trieda'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.TriedaTableAdapter.Fill(Me.InternatDataSet.trieda)
        'TODO: Tento řádek načte data do tabulky 'InternatDataSet.skola'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.SkolaTableAdapter.Fill(Me.InternatDataSet.skola)
        'TODO: Tento řádek načte data do tabulky 'InternatDataSet.skupina'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.SkupinaTableAdapter.Fill(Me.InternatDataSet.skupina)
        'TODO: Tento řádek načte data do tabulky 'InternatDataSet.studentKomplet'. Můžete jej přesunout nebo jej odstranit podle potřeby.
        Me.StudentKompletTableAdapter.Fill(Me.InternatDataSet.studentKomplet)

        'hlavne nastavenia, rodic posunutie do popredia a maximalizovanie
        'Me.MdiParent = hlavnaAplikacia
        Me.WindowState = FormWindowState.Maximized
        Me.BringToFront()
        'nastavenie comboboxov na prazdne
        skolaComboBox.SelectedValue = -1
        skupinaComboBox.SelectedValue = DBNull.Value
        triedaComboBox.SelectedValue = -1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skupinaComboBox.SelectedIndexChanged

    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        'vloyenie dat do tabulky student

        'Try
        Dim con As New OleDbConnection(pripojovaci_retazec)
        Dim com As New OleDbCommand("INSERT INTO student (priezvisko, meno, datumNarodenia, rodneCislo, miestoNarodenia, ulica, mesto, psc, cisloOp, telefon, datumNastup, datumVystup, idSkupina, idSkola,cisloIzby, idTrieda) VALUES (@priezvisko, @meno, @datumNarodenia, @rodneCislo, @miestoNarodenia, @ulica, @mesto, @psc, @cisloOp, @telefon, @datumNastup, @datumVystup, @idSkupina, @idSkola,@cisloIzby ,@idTrieda)", con)
        With com.Parameters
            .AddWithValue("priezvisko", PriezviskoTextBox.Text)
            .AddWithValue("meno", MenoTextBox.Text)
            If DatumNarodeniaDateTimePicker.Checked = True Then
                .AddWithValue("datumNarodenia", DatumNarodeniaDateTimePicker.Value.Date)
            Else
                .AddWithValue("datumNarodenia", DBNull.Value)
            End If
            .AddWithValue("rodneCislo", RodneCisloTextBox.Text)
            .AddWithValue("miestoNarodenia", MiestoNarodeniaTextBox.Text)
            .AddWithValue("ulica", UlicaTextBox.Text)
            .AddWithValue("mesto", MestoTextBox.Text)
            .AddWithValue("psc", PscTextBox.Text)
            .AddWithValue("cisloOp", CisloOpTextBox.Text)
            .AddWithValue("telefon", TelefonTextBox.Text)
            If DatumNastupDateTimePicker.Checked = True Then
                .AddWithValue("datumNastup", DatumNastupDateTimePicker.Value.Date)
            Else
                .AddWithValue("datumNastup", DBNull.Value)
            End If
            If DatumVystupDateTimePicker.Checked = True Then
                .AddWithValue("datumVystup", DatumVystupDateTimePicker.Value.Date)
            Else
                .AddWithValue("datumVystup", DBNull.Value)
            End If
            If skupinaComboBox.SelectedValue <> -1 Then
                .AddWithValue("idSkupina", skupinaComboBox.SelectedValue)
            Else
                .AddWithValue("idSkupina", DBNull.Value)
            End If

            If skolaComboBox.SelectedValue <> -1 Then
                .AddWithValue("idSkola", skolaComboBox.SelectedValue)
            Else
                .AddWithValue("idSkola", DBNull.Value)
            End If
            .AddWithValue("cisloIzby", CisloIzbyTextBox.Text)
            If triedaComboBox.SelectedValue <> -1 Then
                .AddWithValue("idTrieda", triedaComboBox.SelectedValue)
            Else
                .AddWithValue("idTrieda", DBNull.Value)
            End If

        End With

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        'update tabulky
        Me.StudentKompletTableAdapter.Fill(Me.InternatDataSet.studentKomplet)
        'Catch ex As Exception
        'MsgBox("vyskytla sa chyba pri vkladani dat do tabulky student")
        'End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(skupinaComboBox.SelectedValue)
    End Sub
End Class