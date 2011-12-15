Public Class student

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        skupinaComboBox.SelectedValue = -1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles skupinaComboBox.SelectedIndexChanged

    End Sub

    Private Sub ulozButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ulozButton.Click
        'vloyenie dat do tabulky student

        Try
            Dim con As New OleDbConnection(pripojovaci_retazec)
            Dim com As New OleDbCommand("INSERT INTO student (priezvisko, meno, datumNarodenia, rodneCislo, miestoNarodenia, ulica, mesto, psc, cisloOp, telefon, datumNastup, datumVystup, idSkupina, idSkola) VALUES (@priezvisko, @meno, @datumNarodenia, @rodneCislo, @miestoNarodenia, @ulica, @mesto, @psc, @cisloOp, @telefon, @datumNastup, @datumVystup, @idSkupina, @idSkola)", con)
            With com.Parameters
                .AddWithValue("priezvisko", PriezviskoTextBox.Text)
                .AddWithValue("meno", MenoTextBox.Text)
                .AddWithValue("datumNarodenia", DatumNarodeniaDateTimePicker.Value.Date)
                .AddWithValue("rodneCislo", RodneCisloTextBox.Text)
                .AddWithValue("miestoNarodenia", MiestoNarodeniaTextBox.Text)
                .AddWithValue("ulica", UlicaTextBox.Text)
                .AddWithValue("mesto", MestoTextBox.Text)
                .AddWithValue("psc", PscTextBox.Text)
                .AddWithValue("cisloOp", CisloOpTextBox.Text)
                .AddWithValue("telefon", TelefonTextBox.Text)
                .AddWithValue("datumNastup", DatumNastupDateTimePicker.Value.Date)
                .AddWithValue("datumVystup", DatumVystupDateTimePicker.Value.Date)
                .AddWithValue("idSkupina", skupinaComboBox.SelectedValue)
                .AddWithValue("idSkola", skolaComboBox.SelectedValue)

            End With

            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            'update tabulky
            Me.StudentKompletTableAdapter.Fill(Me.InternatDataSet.studentKomplet)
        Catch ex As Exception
            MsgBox("vyskytla sa chyba pri vkladani dat do tabulky student")
        End Try
    End Sub
End Class