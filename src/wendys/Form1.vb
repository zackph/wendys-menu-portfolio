Public Class frmMenu

    Private Sub Button65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMzChs.Click

    End Sub
    Private Sub Button55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLettuce.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " LETTUCE")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub
    Private Sub Button60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKetch.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " KETCHUP")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWellDone.Click

    End Sub
    Private Sub Button80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlain.Click

    End Sub
    Private Sub Button70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPremBun.Click

    End Sub

    Private Sub btnFrosty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrosty.Click

    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJrCheese.Click

    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJrBurger.Click

    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDblJrBcn.Click

    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJrBcn.Click

    End Sub

    Private Sub btnBurgers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurgers.Click
        btnBurgers.Visible = False
        btnChicken.Visible = False
        btnCombos.Visible = False
        btnPotatoes.Visible = False
        btnChiliFries.Visible = False
        btnKidsMeals.Visible = False
        btnDrinks.Visible = False
        btnCoffee.Visible = False
        btnSalads.Visible = False
        btnFrosty.Visible = False
        btnPromoItems.Visible = False
        btnDiscount.Visible = False
        btnGcIssue.Visible = False
        btnGcReload.Visible = False
        btnGcBalance.Visible = False
        btnMaxBal.Visible = False
        btnVersion.Visible = False

        btnBurgers2.Visible = True
        btnChicken2.Visible = True
        btnCombos2.Visible = True
        btnPotatoes2.Visible = True
        btnChiliFries2.Visible = True
        btnKidsMeals2.Visible = True
        btnDrinks2.Visible = True
        btnSalads2.Visible = True
        btnPromos2.Visible = True
        btnFrosty2.Visible = True

        btnSingle.Visible = True
        btnDouble.Visible = True
        btnTriple.Visible = True
        btnBcnSingle.Visible = True
        btnBcnDouble.Visible = True
        btnBcnTriple.Visible = True
        btnTripleStack.Visible = True
        btnDoubleStack.Visible = True
        btnJrBcn.Visible = True
        btnDblJrBcn.Visible = True
        btnJrDlx.Visible = True
        btnSonBcn.Visible = True
        btnJrBurger.Visible = True
        btnJrCheese.Visible = True
        btnVeggiSand.Visible = True

        btnClose.Visible = True
        btnNo.Visible = True
        btnAdd.Visible = True
        btnOnly.Visible = True
        btnExtra.Visible = True
        btnLite.Visible = True
        btnOnSide.Visible = True
        btnMayo.Visible = True
        btnKetch.Visible = True
        btnMust.Visible = True
        btnHoneyMust.Visible = True
        btnTomato.Visible = True
        btnLettuce.Visible = True
        btnPickle.Visible = True
        btnOnion.Visible = True
        btnSubMzChs.Visible = True
        btnAddMzChs.Visible = True
        btnSalt.Visible = True
        btnPremBcn.Visible = True
        btnRegBun.Visible = True
        btnPremBun.Visible = True
        btnBbqSauce.Visible = True
        btnCheese.Visible = True
        btn1000island.Visible = True
        btnWellDone.Visible = True
        btnXtraGuac.Visible = True
        btnMoreCond.Visible = True
        btnExtraMeat.Visible = True
        btnPlain.Visible = True
        btnEverything.Visible = True
        btnDeluxe.Visible = True


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        btnBurgers.Visible = True
        btnChicken.Visible = True
        btnCombos.Visible = True
        btnPotatoes.Visible = True
        btnChiliFries.Visible = True
        btnKidsMeals.Visible = True
        btnDrinks.Visible = True
        btnCoffee.Visible = True
        btnSalads.Visible = True
        btnFrosty.Visible = True
        btnPromoItems.Visible = True
        btnDiscount.Visible = True
        btnGcIssue.Visible = True
        btnGcReload.Visible = True
        btnGcBalance.Visible = True
        btnMaxBal.Visible = True
        btnVersion.Visible = True

        btnBurgers2.Visible = False
        btnChicken2.Visible = False
        btnCombos2.Visible = False
        btnPotatoes2.Visible = False
        btnChiliFries2.Visible = False
        btnKidsMeals2.Visible = False
        btnDrinks2.Visible = False
        btnSalads2.Visible = False
        btnPromos2.Visible = False
        btnFrosty2.Visible = False

        btnSingle.Visible = False
        btnDouble.Visible = False
        btnTriple.Visible = False
        btnBcnSingle.Visible = False
        btnBcnDouble.Visible = False
        btnBcnTriple.Visible = False
        btnTripleStack.Visible = False
        btnDoubleStack.Visible = False
        btnJrBcn.Visible = False
        btnDblJrBcn.Visible = False
        btnJrDlx.Visible = False
        btnSonBcn.Visible = False
        btnJrBurger.Visible = False
        btnJrCheese.Visible = False
        btnVeggiSand.Visible = False

        btnNo.Visible = False
        btnAdd.Visible = False
        btnOnly.Visible = False
        btnExtra.Visible = False
        btnLite.Visible = False
        btnOnSide.Visible = False
        btnMayo.Visible = False
        btnKetch.Visible = False
        btnMust.Visible = False
        btnHoneyMust.Visible = False
        btnTomato.Visible = False
        btnLettuce.Visible = False
        btnPickle.Visible = False
        btnOnion.Visible = False
        btnSubMzChs.Visible = False
        btnAddMzChs.Visible = False
        btnSalt.Visible = False
        btnPremBcn.Visible = False
        btnRegBun.Visible = False
        btnPremBun.Visible = False
        btnBbqSauce.Visible = False
        btnCheese.Visible = False
        btn1000island.Visible = False
        btnWellDone.Visible = False
        btnXtraGuac.Visible = False
        btnMoreCond.Visible = False
        btnExtraMeat.Visible = False
        btnPlain.Visible = False
        btnEverything.Visible = False
        btnDeluxe.Visible = False
        btnClose.Visible = False


    End Sub

    Private Sub btnChicken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChicken.Click
        btnBurgers.Visible = False
        btnChicken.Visible = False
        btnCombos.Visible = False
        btnPotatoes.Visible = False
        btnChiliFries.Visible = False
        btnKidsMeals.Visible = False
        btnDrinks.Visible = False
        btnCoffee.Visible = False
        btnSalads.Visible = False
        btnFrosty.Visible = False
        btnPromoItems.Visible = False
        btnDiscount.Visible = False
        btnGcIssue.Visible = False
        btnGcReload.Visible = False
        btnGcBalance.Visible = False
        btnMaxBal.Visible = False
        btnVersion.Visible = False

        btnBurgers2.Visible = True
        btnChicken2.Visible = True
        btnCombos2.Visible = True
        btnPotatoes2.Visible = True
        btnChiliFries2.Visible = True
        btnKidsMeals2.Visible = True
        btnDrinks2.Visible = True
        btnSalads2.Visible = True
        btnPromos2.Visible = True
        btnFrosty2.Visible = True

        btnHmStyle.Visible = True
        btnSpicy.Visible = True
        btnGrilled.Visible = True
        btnAsiago.Visible = True
        btnCrspyDlx.Visible = True
        btnHmWrap.Visible = True
        btnSpWrap.Visible = True
        btnGrilWrap.Visible = True
        btnCeasarWrap.Visible = True
        btnCrispy.Visible = True
        btn4pcSnug.Visible = True
        btn6pcSnug.Visible = True
        btn4pcNug.Visible = True
        btn6pcNug.Visible = True
        btnSauce.Visible = True

        btnClose2.Visible = True
        btnNo.Visible = True
        btnAdd.Visible = True
        btnOnly.Visible = True
        btnExtra.Visible = True
        btnLite.Visible = True
        btnOnSide.Visible = True
        btnMayo.Visible = True
        btnKetch.Visible = True
        btnMust.Visible = True
        btnHoneyMust.Visible = True
        btnTomato.Visible = True
        btnLettuce.Visible = True
        btnPickle.Visible = True
        btnOnion.Visible = True
        btnSubMzChs.Visible = True
        btnAddMzChs.Visible = True
        btnSalt.Visible = True
        btnPremBcn.Visible = True
        btnRegBun.Visible = True
        btnPremBun.Visible = True
        btnBbqSauce.Visible = True
        btnCheese.Visible = True
        btn1000island.Visible = True
        btnWellDone.Visible = True
        btnXtraGuac.Visible = True
        btnMoreCond.Visible = True
        btnExtraMeat.Visible = True
        btnPlain.Visible = True
        btnEverything.Visible = True
        btnDeluxe.Visible = True
    End Sub

    Private Sub btnClose2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose2.Click
        btnBurgers.Visible = True
        btnChicken.Visible = True
        btnCombos.Visible = True
        btnPotatoes.Visible = True
        btnChiliFries.Visible = True
        btnKidsMeals.Visible = True
        btnDrinks.Visible = True
        btnCoffee.Visible = True
        btnSalads.Visible = True
        btnFrosty.Visible = True
        btnPromoItems.Visible = True
        btnDiscount.Visible = True
        btnGcIssue.Visible = True
        btnGcReload.Visible = True
        btnGcBalance.Visible = True
        btnMaxBal.Visible = True
        btnVersion.Visible = True

        btnBurgers2.Visible = False
        btnChicken2.Visible = False
        btnCombos2.Visible = False
        btnPotatoes2.Visible = False
        btnChiliFries2.Visible = False
        btnKidsMeals2.Visible = False
        btnDrinks2.Visible = False
        btnSalads2.Visible = False
        btnPromos2.Visible = False
        btnFrosty2.Visible = False

        btnHmStyle.Visible = False
        btnSpicy.Visible = False
        btnGrilled.Visible = False
        btnAsiago.Visible = False
        btnCrspyDlx.Visible = False
        btnHmWrap.Visible = False
        btnSpWrap.Visible = False
        btnGrilWrap.Visible = False
        btnCeasarWrap.Visible = False
        btnCrispy.Visible = False
        btn4pcSnug.Visible = False
        btn6pcSnug.Visible = False
        btn4pcNug.Visible = False
        btn6pcNug.Visible = False
        btnSauce.Visible = False

        btnNo.Visible = False
        btnAdd.Visible = False
        btnOnly.Visible = False
        btnExtra.Visible = False
        btnLite.Visible = False
        btnOnSide.Visible = False
        btnMayo.Visible = False
        btnKetch.Visible = False
        btnMust.Visible = False
        btnHoneyMust.Visible = False
        btnTomato.Visible = False
        btnLettuce.Visible = False
        btnPickle.Visible = False
        btnOnion.Visible = False
        btnSubMzChs.Visible = False
        btnAddMzChs.Visible = False
        btnSalt.Visible = False
        btnPremBcn.Visible = False
        btnRegBun.Visible = False
        btnPremBun.Visible = False
        btnBbqSauce.Visible = False
        btnCheese.Visible = False
        btn1000island.Visible = False
        btnWellDone.Visible = False
        btnXtraGuac.Visible = False
        btnMoreCond.Visible = False
        btnExtraMeat.Visible = False
        btnPlain.Visible = False
        btnEverything.Visible = False
        btnDeluxe.Visible = False
        btnClose2.Visible = False

    End Sub

    Private Sub btnBurgers2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurgers2.Click
        btnBurgers2.Visible = True
        btnChicken2.Visible = True
        btnCombos2.Visible = True
        btnPotatoes2.Visible = True
        btnChiliFries2.Visible = True
        btnKidsMeals2.Visible = True
        btnDrinks2.Visible = True
        btnSalads2.Visible = True
        btnPromos2.Visible = True
        btnFrosty2.Visible = True

        btnSingle.Visible = True
        btnDouble.Visible = True
        btnTriple.Visible = True
        btnBcnSingle.Visible = True
        btnBcnDouble.Visible = True
        btnBcnTriple.Visible = True
        btnTripleStack.Visible = True
        btnDoubleStack.Visible = True
        btnJrBcn.Visible = True
        btnDblJrBcn.Visible = True
        btnJrDlx.Visible = True
        btnSonBcn.Visible = True
        btnJrBurger.Visible = True
        btnJrCheese.Visible = True
        btnVeggiSand.Visible = True
        btnClose.Visible = True

        btnNo.Visible = True
        btnAdd.Visible = True
        btnOnly.Visible = True
        btnExtra.Visible = True
        btnLite.Visible = True
        btnOnSide.Visible = True
        btnMayo.Visible = True
        btnKetch.Visible = True
        btnMust.Visible = True
        btnHoneyMust.Visible = True
        btnTomato.Visible = True
        btnLettuce.Visible = True
        btnPickle.Visible = True
        btnOnion.Visible = True
        btnSubMzChs.Visible = True
        btnAddMzChs.Visible = True
        btnSalt.Visible = True
        btnPremBcn.Visible = True
        btnRegBun.Visible = True
        btnPremBun.Visible = True
        btnBbqSauce.Visible = True
        btnCheese.Visible = True
        btn1000island.Visible = True
        btnWellDone.Visible = True
        btnXtraGuac.Visible = True
        btnMoreCond.Visible = True
        btnExtraMeat.Visible = True
        btnPlain.Visible = True
        btnEverything.Visible = True
        btnDeluxe.Visible = True

        btnHmStyle.Visible = False
        btnSpicy.Visible = False
        btnGrilled.Visible = False
        btnAsiago.Visible = False
        btnCrspyDlx.Visible = False
        btnHmWrap.Visible = False
        btnSpWrap.Visible = False
        btnGrilWrap.Visible = False
        btnCeasarWrap.Visible = False
        btnCrispy.Visible = False
        btn4pcSnug.Visible = False
        btn6pcSnug.Visible = False
        btn4pcNug.Visible = False
        btn6pcNug.Visible = False
        btnSauce.Visible = False
        btnClose2.Visible = False

    End Sub

    Private Sub btnChicken2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChicken2.Click
        btnHmStyle.Visible = True
        btnSpicy.Visible = True
        btnGrilled.Visible = True
        btnAsiago.Visible = True
        btnCrspyDlx.Visible = True
        btnHmWrap.Visible = True
        btnSpWrap.Visible = True
        btnGrilWrap.Visible = True
        btnCeasarWrap.Visible = True
        btnCrispy.Visible = True
        btn4pcSnug.Visible = True
        btn6pcSnug.Visible = True
        btn4pcNug.Visible = True
        btn6pcNug.Visible = True
        btnSauce.Visible = True
        btnClose2.Visible = True

        btnClose.Visible = True
        btnNo.Visible = True
        btnAdd.Visible = True
        btnOnly.Visible = True
        btnExtra.Visible = True
        btnLite.Visible = True
        btnOnSide.Visible = True
        btnMayo.Visible = True
        btnKetch.Visible = True
        btnMust.Visible = True
        btnHoneyMust.Visible = True
        btnTomato.Visible = True
        btnLettuce.Visible = True
        btnPickle.Visible = True
        btnOnion.Visible = True
        btnSubMzChs.Visible = True
        btnAddMzChs.Visible = True
        btnSalt.Visible = True
        btnPremBcn.Visible = True
        btnRegBun.Visible = True
        btnPremBun.Visible = True
        btnBbqSauce.Visible = True
        btnCheese.Visible = True
        btn1000island.Visible = True
        btnWellDone.Visible = True
        btnXtraGuac.Visible = True
        btnMoreCond.Visible = True
        btnExtraMeat.Visible = True
        btnPlain.Visible = True
        btnEverything.Visible = True
        btnDeluxe.Visible = True

        btnSingle.Visible = False
        btnDouble.Visible = False
        btnTriple.Visible = False
        btnBcnSingle.Visible = False
        btnBcnDouble.Visible = False
        btnBcnTriple.Visible = False
        btnTripleStack.Visible = False
        btnDoubleStack.Visible = False
        btnJrBcn.Visible = False
        btnDblJrBcn.Visible = False
        btnJrDlx.Visible = False
        btnSonBcn.Visible = False
        btnJrBurger.Visible = False
        btnJrCheese.Visible = False
        btnVeggiSand.Visible = False
        btnClose.Visible = False

    End Sub
    Dim a As String
    Private Sub btnSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSingle.Click
        Dim price As Double = 3.69
        Dim name As String
        Dim quantity As String
        quantity = TextBox1.Text
        If TextBox1.Text = "" Then
            quantity = 1
        End If
        name = "SINGLE CHZ"
        ListBox1.Items.Add(quantity)
        ListBox2.Items.Add(name)
        ListBox3.Items.Add(price * quantity)
        TextBox1.Text = ""
        ListBox2.SelectedIndex = -1


    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrderTotal.Click
        Dim total1 As Double = 0
        Dim total2 As Double = 0
        Dim tax As Double = 0
        For i As Double = 0 To ListBox3.Items.Count - 1
            total1 += CDbl(ListBox3.Items(i))
            tax = total1 * 0.09
            total2 = total1 + tax
        Next
        TextBox1.Text = ""
        lblTax.Visible = True
        lblTotal.Visible = True
        lblTax2.Visible = True
        lblTotal2.Visible = True
        lblTax2.Text = FormatNumber(tax, 2)
        lblTotal2.Text = FormatNumber(total2, 2)

    End Sub

    Private Sub btn4pcSnug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4pcSnug.Click
        Dim price As Double = 0.99
        Dim name As String
        Dim quantity As String
        quantity = TextBox1.Text
        If TextBox1.Text = "" Then
            quantity = 1
        End If
        name = "4Pc Spicy Nuggets"
        ListBox1.Items.Add(quantity)
        ListBox2.Items.Add(name)
        ListBox3.Items.Add(price * quantity)
        TextBox1.Text = ""
        ListBox2.SelectedIndex = -1

    End Sub

    Private Sub btn4pcNug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4pcNug.Click
        Dim price As Double = 0.99
        Dim name As String
        Dim quantity As String
        quantity = TextBox1.Text
        If TextBox1.Text = "" Then
            quantity = 1
        End If
        name = "4Pc Nuggets"
        ListBox1.Items.Add(quantity)
        ListBox2.Items.Add(name)
        ListBox3.Items.Add(price * quantity)
        TextBox1.Text = ""
        ListBox2.SelectedIndex = -1

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TextBox1.Text = 1
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TextBox1.Text = 2
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox1.Text = 0

    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        TextBox1.Text = 3

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = 4
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = 5
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox1.Text = 6
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = 7
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = 8
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = 9
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblTax.Visible = False
        lblTotal.Visible = False
        lblTax2.Visible = False
        lblTotal2.Visible = False
        TextBox1.Text = ""
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

    End Sub

    Private Sub btnMayo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMayo.Click
        Dim price As Double = 0.0
       
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " MAYO")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        a = "NO"
        btnNo.BackColor = Color.Black
        btnNo.ForeColor = Color.Cyan
        btnAdd.BackColor = Color.Cyan
        btnAdd.ForeColor = Color.Black
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        a = "ADD"
        btnAdd.BackColor = Color.Black
        btnAdd.ForeColor = Color.Cyan
        btnNo.BackColor = Color.Cyan
        btnNo.ForeColor = Color.Black
    End Sub

    Private Sub btnCheese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheese.Click
        Dim price As Double = 0.3
        If a = "NO" Then
            price = 0
        End If
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " CHEESE")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnCancelItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelItems.Click
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
        ListBox3.Items.RemoveAt(ListBox3.SelectedIndex)
        ListBox1.SelectedIndex = -1
        ListBox2.SelectedIndex = -1
        ListBox3.SelectedIndex = -1
    End Sub

    Private Sub btnMust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMust.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " MUSTARD")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnTomato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTomato.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " TOMATO")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnPickle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPickle.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " PICKLES")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnOnion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOnion.Click
        Dim price As Double = 0.0
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " ONION")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnPremBcn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPremBcn.Click
        Dim price As Double = 0.99
        If a = "NO" Then
            price = 0
        End If
        If ListBox2.SelectedIndex = -1 Then
            ListBox2.SelectedIndex = ListBox2.Items.Count - 1
        End If
        ListBox1.Items.Insert(ListBox2.SelectedIndex + 1, "")
        ListBox2.Items.Insert(ListBox2.SelectedIndex + 1, "   " & a & " 4PREMBCN")
        ListBox3.Items.Insert(ListBox2.SelectedIndex + 1, FormatNumber(price))
    End Sub

    Private Sub btnJrDlx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJrDlx.Click
        Dim price As Double = 1.29
        Dim name As String
        Dim quantity As String
        quantity = TextBox1.Text
        If TextBox1.Text = "" Then
            quantity = 1
        End If
        name = "JR CHZ DELUXE"
        ListBox1.Items.Add(quantity)
        ListBox2.Items.Add(name)
        ListBox3.Items.Add(price * quantity)
        TextBox1.Text = ""
        ListBox2.SelectedIndex = -1
    End Sub

    Private Sub btnDouble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDouble.Click
        Dim price As Double = 4.69
        Dim name As String
        Dim quantity As String
        quantity = TextBox1.Text
        If TextBox1.Text = "" Then
            quantity = 1
        End If
        name = "DOUBLE CHZ"
        ListBox1.Items.Add(quantity)
        ListBox2.Items.Add(name)
        ListBox3.Items.Add(price * quantity)
        TextBox1.Text = ""
        ListBox2.SelectedIndex = -1
    End Sub
End Class
