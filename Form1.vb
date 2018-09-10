Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.ASCIIEncoding
Imports System.Text.RegularExpressions

Public Class Form1
    Dim Key As String = "西こ比维吾き弗伊さふつまの德德ひむ艾ちゆに豆めた比つ艾か贼杰"
    Dim keynum As Integer = 894813397
    Public filepath As String
    Public filepath2 As String
    Private Sub LogInButton1_Click(sender As Object, e As EventArgs) Handles LogInButton1.Click
        Try
            If LogInUserTextBox1.Text = "" Then
                MessageBox.Show("Please enter text to encrypt!")
                LogInUserTextBox1.Text = ""
                LogInUserTextBox2.Text = ""
            End If
            If LogInComboBox1.Text = "AES" Then
                LogInUserTextBox2.Text = AES_Encrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "Atom 128" Then

            End If
            If LogInComboBox1.Text = "RC2" Then
                LogInUserTextBox2.Text = RC2_Encrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "RSA" Then
                LogInUserTextBox2.Text = RSA_Encrypt(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "XOR" Then
                LogInUserTextBox2.Text = XOR_Encrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "DES" Then
                LogInUserTextBox2.Text = DES_Encrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "TrippleDES" Then
                LogInUserTextBox2.Text = TripleDES_Encrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "ROT13" Then
                LogInUserTextBox2.Text = ROT13(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Ceasar Shift" Then
                LogInUserTextBox2.Text = EncryptCS(LogInUserTextBox1.Text, keynum)
            End If
            If LogInComboBox1.Text = "Rijndael" Then
                LogInUserTextBox2.Text = Rijndaelcrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "ATOM 128" Then
                LogInUserTextBox2.Text = Atom128_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "HAZZ 15" Then
                LogInUserTextBox2.Text = HAZZ15_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "GILA 7" Then
                LogInUserTextBox2.Text = GILA7_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "ESAB 46" Then
                LogInUserTextBox2.Text = ESAB46_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Megan 35" Then
                LogInUserTextBox2.Text = MEGAN35_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Zong 22" Then
                LogInUserTextBox2.Text = ZONG22_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "TIGO3FX" Then
                LogInUserTextBox2.Text = TIGO3FX_Encode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "EnvY'S Encryption" Then
                LogInUserTextBox2.Text = EnvY_Encrypt(LogInUserTextBox1.Text, Key)
            End If
        Catch ex As Exception
            MsgBox("An error has occoured whilst encrypting your text.")
        End Try

    End Sub

    Private Sub LogInButton2_Click(sender As Object, e As EventArgs) Handles LogInButton2.Click
        Try
            If LogInUserTextBox1.Text = "" Then
                MessageBox.Show("Please enter text to decrypt!")
                LogInUserTextBox1.Text = ""
                LogInUserTextBox2.Text = ""
            End If
            If LogInComboBox1.Text = "AES" Then
                LogInUserTextBox2.Text = AES_Decrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "RC2" Then
                LogInUserTextBox2.Text = RC2_Decrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "RSA" Then
                LogInUserTextBox2.Text = RSA_Decrypt(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "XOR" Then
                LogInUserTextBox2.Text = XOR_Decrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "DES" Then
                LogInUserTextBox2.Text = DES_Decrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "TrippleDES" Then
                LogInUserTextBox2.Text = TripleDES_Decrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "ROT13" Then
                LogInUserTextBox2.Text = ROT13(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Ceasar Shift" Then
                LogInUserTextBox2.Text = DecryptCS(LogInUserTextBox1.Text, keynum)
            End If
            If LogInComboBox1.Text = "Rijndael" Then
                LogInUserTextBox2.Text = RijndaelDecrypt(LogInUserTextBox1.Text, Key)
            End If
            If LogInComboBox1.Text = "ATOM 128" Then
                LogInUserTextBox2.Text = Atom128_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "HAZZ 15" Then
                LogInUserTextBox2.Text = HAZZ15_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "GILA 7" Then
                LogInUserTextBox2.Text = GILA7_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "ESAB 46" Then
                LogInUserTextBox2.Text = ESAB46_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Megan 35" Then
                LogInUserTextBox2.Text = MEGAN35_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "Zong 22" Then
                LogInUserTextBox2.Text = ZONG22_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "TIGO3FX" Then
                LogInUserTextBox2.Text = TIGO3FX_Decode(LogInUserTextBox1.Text)
            End If
            If LogInComboBox1.Text = "EnvY'S Encryption" Then
                LogInUserTextBox2.Text = EnvY_Decrypt(LogInUserTextBox1.Text, Key)
            End If
        Catch ex As Exception
            MsgBox("An error has occoured whilst decrypting your text.")
        End Try

    End Sub
    Dim ofd As New OpenFileDialog
    Dim sfd As New SaveFileDialog
    Dim a As String = ofd.FileName
    Private Sub LogInButton3_Click(sender As Object, e As EventArgs) Handles LogInButton3.Click
        If ofd.ShowDialog = DialogResult.OK Then
            filepath = ofd.FileName
            LogInUserTextBox3.Text = ofd.FileName
            a.Split(".")
            a = a
        End If
    End Sub

    Private Sub LogInLogButton1_Click(sender As Object, e As EventArgs) Handles LogInLogButton1.Click
        If LogInUserTextBox3.Text <> "" Then
            LogInLabel7.Text = "Encrypting..."
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Dim READBYTES As Byte() = System.IO.File.ReadAllBytes(filepath)
        Dim AESBYTES As Byte() = AESFile.AESFile_Encrypt(READBYTES, Key)
        sfd.Filter = "exe|*.exe"
        sfd.DefaultExt = a + "-" + ".exe"
        If sfd.ShowDialog = DialogResult.OK Then

            IO.File.WriteAllBytes(sfd.FileName, AESBYTES)
        End If
        LogInLabel7.Text = "Encrypted!"
    End Sub

    Dim ofd2 As New OpenFileDialog
    Dim sfd2 As New SaveFileDialog
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Dim READBYTES As Byte() = System.IO.File.ReadAllBytes(filepath2)
        Dim AESBYTES As Byte() = AESFile.AESFile_Decrypt(READBYTES, Key)
        If sfd2.ShowDialog = DialogResult.OK Then
            IO.File.WriteAllBytes(sfd2.FileName, AESBYTES)
        End If
        LogInLabel8.Text = "Decrypted!"
    End Sub

    Private Sub LogInLogButton2_Click(sender As Object, e As EventArgs) Handles LogInLogButton2.Click
        If LogInUserTextBox4.Text <> "" Then
            LogInLabel8.Text = "Decrypting..."
            Timer2.Start()
        End If
    End Sub

    Private Sub LogInButton4_Click(sender As Object, e As EventArgs) Handles LogInButton4.Click
        sfd2.Filter = "exe|*.exe" 'fix
        sfd2.DefaultExt = ".exe"  'fix 
        If ofd2.ShowDialog = DialogResult.OK Then
            LogInUserTextBox4.Text = System.IO.Path.GetFileName(ofd2.FileName)
            filepath2 = ofd2.FileName
        End If
    End Sub

#Region "Methods"
#Region "AES"
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = System.Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = System.Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
#End Region
#Region "Rc2"
    Public Function RC2_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim RC2 As New System.Security.Cryptography.RC2CryptoServiceProvider
        Dim Hash_RC2 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash() As Byte = Hash_RC2.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))

            RC2.Key = hash
            RC2.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = System.Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function RC2_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim RC2 As New System.Security.Cryptography.RC2CryptoServiceProvider
        Dim Hash_RC2 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash() As Byte = Hash_RC2.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            RC2.Key = hash
            RC2.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = RC2.CreateDecryptor
            Dim Buffer As Byte() = System.Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
#End Region
#Region "RSA"
    Public Function RSA_Encrypt(ByVal Input As String) As String
        Dim cp As New Security.Cryptography.CspParameters
        cp.Flags = Security.Cryptography.CspProviderFlags.UseMachineKeyStore
        cp.KeyContainerName = Key
        Dim RSA As New Security.Cryptography.RSACryptoServiceProvider(cp)

        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(Input)
        Dim encrypted As Byte() = RSA.Encrypt(buffer, True)
        Return System.Convert.ToBase64String(encrypted)
    End Function
    Public Function RSA_Decrypt(ByVal Input As String) As String
        Dim cp As New Security.Cryptography.CspParameters
        cp.Flags = Security.Cryptography.CspProviderFlags.UseMachineKeyStore
        cp.KeyContainerName = Key
        Dim RSA As New Security.Cryptography.RSACryptoServiceProvider(cp)
        Dim buffer As Byte() = System.Convert.FromBase64String(Input)
        Dim decrypted As Byte() = RSA.Decrypt(buffer, True)
        Return System.Text.Encoding.UTF8.GetString(decrypted)
    End Function
#End Region
#Region "Xor"
#Region "Normal"
    Public Function XOR_Encrypt(ByVal Input As String, ByVal pass As String) As String
        Dim out As New System.Text.StringBuilder
        Dim u As Integer
        For i As Integer = 0 To Input.Length - 1
            Dim tmp As String = Hex(Asc(Input(i)) Xor Asc(pass(u)))
            If tmp.Length = 1 Then tmp = "0" & tmp
            out.Append(tmp)
            If u = pass.Length - 1 Then u = 0 Else u = u + 1
        Next
        Return out.ToString
    End Function
    Public Function XOR_Decrypt(ByVal Input As String, ByVal pass As String) As String
        Dim out As New System.Text.StringBuilder
        Dim u As Integer
        For i As Integer = 0 To Input.Length - 1 Step +2
            Dim tmp As String = Chr(("&H" & Input.Substring(i, 2)) Xor Asc(pass(u)))
            out.Append(tmp)
            If u = pass.Length - 1 Then u = 0 Else u = u + 1
        Next
        Return out.ToString
    End Function
#End Region
#End Region
#Region "DES"
    Public Function DES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim DES As New System.Security.Cryptography.DESCryptoServiceProvider
        Dim Hash_DES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(7) As Byte
            Dim temp As Byte() = Hash_DES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 8)
            DES.Key = hash
            DES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = System.Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function DES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim DES As New System.Security.Cryptography.DESCryptoServiceProvider
        Dim Hash_DES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(7) As Byte
            Dim temp As Byte() = Hash_DES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 8)
            DES.Key = hash
            DES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = DES.CreateDecryptor
            Dim Buffer As Byte() = System.Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
#End Region
#Region "Triple DES"
    Public Function TripleDES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim TripleDES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
        Dim Hash_TripleDES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(23) As Byte
            Dim temp As Byte() = Hash_TripleDES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 8)
            TripleDES.Key = hash
            TripleDES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = TripleDES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = System.Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function TripleDES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim TripleDES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
        Dim Hash_TripleDES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(23) As Byte
            Dim temp As Byte() = Hash_TripleDES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 8)
            TripleDES.Key = hash
            TripleDES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = TripleDES.CreateDecryptor
            Dim Buffer As Byte() = System.Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

#End Region
#Region "ROT13"
    Public Function ROT13(ByVal input As String) As String
        Dim out As New System.Text.StringBuilder
        For i As Integer = 0 To input.Length - 1
            out.Append(Chr(Asc(input(i)) Xor 13))
        Next
        Return out.ToString
    End Function
#End Region
#Region "Ceaser shift"
    Public Function EncryptCS(ByVal PlainText As String, ByVal Key As Integer) As String
        Dim PlainChar() As Char = PlainText.ToCharArray()
        Dim Ascii(PlainChar.Length) As Integer
        For Count As Integer = 0 To PlainChar.Length - 1
            Ascii(Count) = Asc(PlainChar(Count))
            If Ascii(Count) >= 65 And Ascii(Count) <= 90 Then
                Ascii(Count) = ((Ascii(Count) - 65 + Key) Mod 26) + 65
            ElseIf Ascii(Count) >= 97 And Ascii(Count) <= 122 Then
                Ascii(Count) = ((Ascii(Count) - 97 + Key) Mod 26) + 97
            End If
            PlainChar(Count) = Chr(Ascii(Count))
        Next
        Return PlainChar
    End Function
    Public Function DecryptCS(ByVal CipherText As String, ByVal Key As Integer) As String
        Dim CipherChar() As Char = CipherText.ToCharArray()
        Dim Ascii(CipherChar.Length) As Integer

        For Count As Integer = 0 To CipherChar.Length - 1
            Ascii(Count) = Asc(CipherChar(Count))
            If Ascii(Count) >= 65 And Ascii(Count) <= 90 Then
                Ascii(Count) = ((Ascii(Count) - 65 - (Key Mod 26) + 26)) Mod 26 + 65
            ElseIf Ascii(Count) >= 97 And Ascii(Count) <= 122 Then
                Ascii(Count) = (((Ascii(Count) - 97 - (Key Mod 26) + 26)) Mod 26) + 97
            End If
            CipherChar(Count) = Chr(Ascii(Count))
        Next
        Return CipherChar
    End Function
#End Region
#Region "Rijndael"
    Public Shared Function RijndaelDecrypt(ByVal UDecryptU As String, ByVal UKeyU As String)
        Dim XoAesProviderX As New RijndaelManaged
        Dim XbtCipherX() As Byte
        Dim XbtSaltX() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim XoKeyGeneratorX As New Rfc2898DeriveBytes(UKeyU, XbtSaltX)
        XoAesProviderX.Key = XoKeyGeneratorX.GetBytes(XoAesProviderX.Key.Length)
        XoAesProviderX.IV = XoKeyGeneratorX.GetBytes(XoAesProviderX.IV.Length)
        Dim XmsX As New IO.MemoryStream
        Dim XcsX As New CryptoStream(XmsX, XoAesProviderX.CreateDecryptor(),
          CryptoStreamMode.Write)
        Try
            XbtCipherX = System.Convert.FromBase64String(UDecryptU)
            XcsX.Write(XbtCipherX, 0, XbtCipherX.Length)
            XcsX.Close()
            UDecryptU = System.Text.Encoding.UTF8.GetString(XmsX.ToArray)
        Catch
        End Try
        Return UDecryptU
    End Function
    Public Shared Function Rijndaelcrypt(ByVal File As String, ByVal Key As String)
        Dim oAesProvider As New RijndaelManaged
        Dim btClear() As Byte
        Dim btSalt() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes(Key, btSalt)
        oAesProvider.Key = oKeyGenerator.GetBytes(oAesProvider.Key.Length)
        oAesProvider.IV = oKeyGenerator.GetBytes(oAesProvider.IV.Length)
        Dim ms As New IO.MemoryStream
        Dim cs As New CryptoStream(ms,
          oAesProvider.CreateEncryptor(),
          CryptoStreamMode.Write)
        btClear = System.Text.Encoding.UTF8.GetBytes(File)
        cs.Write(btClear, 0, btClear.Length)
        cs.Close()
        File = System.Convert.ToBase64String(ms.ToArray)
        Return File
    End Function
#End Region
#Region "Atom 128"
    Public Function Atom128_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Dim keyatom As String = "HNO4klm6ij9n+J2hyf0gzA8uvwDEq3X1Q7ZKeFrWcVTts/MRGYbdxSo=ILaUpPBC5"
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(keyatom(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function Atom128_Decode(ByVal input As String) As String
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Dim keyatom As String = "HNO4klm6ij9n+J2hyf0gzA8uvwDEq3X1Q7ZKeFrWcVTts/MRGYbdxSo=ILaUpPBC5"
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = keyatom.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "HAZZ 15"
    Public Function HAZZ15_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "HNO4klm6ij9n+J2hyf0gzA8uvwDEq3X1Q7ZKeFrWcVTts/MRGYbdxSo=ILaUpPBC5"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function HAZZ15_Decode(ByVal input As String) As String
        Dim key As String = "HNO4klm6ij9n+J2hyf0gzA8uvwDEq3X1Q7ZKeFrWcVTts/MRGYbdxSo=ILaUpPBC5"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "GILA 7"
    Public Function GILA7_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "7ZSTJK+W=cVtBCasyf0gzA8uvwDEq3XH/1RMNOILPQU4klm65YbdeFrx2hij9nopG"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function GILA7_Decode(ByVal input As String) As String
        Dim key As String = "7ZSTJK+W=cVtBCasyf0gzA8uvwDEq3XH/1RMNOILPQU4klm65YbdeFrx2hij9nopG"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "ESAB 46"
    Public Function ESAB46_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "ABCDqrs456tuvNOPwxyz012KLM3789=+QRSTUVWXYZabcdefghijklmnopEFGHIJ/"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function ESAB46_Decode(ByVal input As String) As String
        Dim key As String = "ABCDqrs456tuvNOPwxyz012KLM3789=+QRSTUVWXYZabcdefghijklmnopEFGHIJ/"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "Megan 35"
    Public Function MEGAN35_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "3GHIJKLMNOPQRSTUb=cdefghijklmnopWXYZ/12+406789VaqrstuvwxyzABCDEF5"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function MEGAN35_Decode(ByVal input As String) As String
        Dim key As String = "3GHIJKLMNOPQRSTUb=cdefghijklmnopWXYZ/12+406789VaqrstuvwxyzABCDEF5"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "Zong 22"
    Public Function ZONG22_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "ZKj9n+yf0wDVX1s/5YbdxSo=ILaUpPBCHg8uvNO4klm6iJGhQ7eFrWczAMEq3RTt2"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function ZONG22_Decode(ByVal input As String) As String
        Dim key As String = "ZKj9n+yf0wDVX1s/5YbdxSo=ILaUpPBCHg8uvNO4klm6iJGhQ7eFrWczAMEq3RTt2"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "AESFILE"
    Public Class AESFile
        Public Shared Function AESFile_Encrypt(ByVal input As Byte(), ByVal pass As String) As Byte()
            Dim AES As New System.Security.Cryptography.RijndaelManaged
            Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim Encrypted As Byte()
            Try
                Dim hash(31) As Byte
                Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
                Array.Copy(temp, 0, hash, 0, 16)
                Array.Copy(temp, 0, hash, 15, 16)
                AES.Key = hash
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
                Dim buffer As Byte() = input
                Encrypted = DESEncrypter.TransformFinalBlock(buffer, 0, buffer.Length)
                Return Encrypted
            Catch ex As Exception
            End Try
        End Function
        Public Shared Function AESFile_Decrypt(ByVal input As Byte(), ByVal pass As String) As Byte()
            Dim AES As New System.Security.Cryptography.RijndaelManaged
            Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim decrypted As Byte()
            Try
                Dim hash(31) As Byte
                Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
                Array.Copy(temp, 0, hash, 0, 16)
                Array.Copy(temp, 0, hash, 15, 16)
                AES.Key = hash
                AES.Mode = Security.Cryptography.CipherMode.ECB
                Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
                Dim Buffer As Byte() = input
                decrypted = DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length)
                Return decrypted
            Catch ex As Exception
            End Try
        End Function
    End Class
#End Region
#Region "TIGO3FX"
    Public Function TIGO3FX_Encode(ByVal input As String) As String
        input = Uri.EscapeDataString(input)
        Dim key As String = "FrsxyzA8VtuvwDEqWZ/1+4klm67=cBCa5Ybdef0g2hij9nopMNO3GHIRSTJKLPQUX"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs As Integer() = {0, 0, 0}
            For b As Integer = 0 To 2
                If i < input.Length Then chrs(b) = Asc(input(i))
                i += 1
            Next
            enc(0) = chrs(0) >> 2
            enc(1) = ((chrs(0) And 3) << 4) Or (chrs(1) >> 4)
            enc(2) = ((chrs(1) And 15) << 2) Or (chrs(2) >> 6)
            enc(3) = chrs(2) And 63
            If chrs(1) = 0 Then
                enc(2) = 64
                enc(3) = 64
            End If
            If chrs(2) = 0 Then
                enc(3) = 64
            End If
            For Each x As Integer In enc
                out.Append(key(x))
            Next
        Loop While i < input.Length
        Return out.ToString
    End Function
    Public Function TIGO3FX_Decode(ByVal input As String) As String
        Dim key As String = "FrsxyzA8VtuvwDEqWZ/1+4klm67=cBCa5Ybdef0g2hij9nopMNO3GHIRSTJKLPQUX"
        Dim out As New System.Text.StringBuilder
        Dim i As Integer
        Do
            Dim enc(3) As Integer
            Dim chrs() As Integer = {0, 0, 0}
            For b As Integer = 0 To 3
                enc(b) = key.IndexOf(input(i))
                i = i + 1
            Next
            chrs(0) = (enc(0) << 2) Or (enc(1) >> 4)
            chrs(1) = (enc(1) And 15) << 4 Or (enc(2) >> 2)
            chrs(2) = (enc(2) And 3) << 6 Or enc(3)
            out.Append(Chr(chrs(0)))
            If enc(2) <> 64 Then out.Append(Chr(chrs(1)))
            If enc(3) <> 64 Then out.Append(Chr(chrs(2)))
        Loop While i < input.Length
        Return out.ToString
    End Function
#End Region
#Region "EnvY'S Encryption"
    Public Function EnvY_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim out As String
        input = LogInUserTextBox1.Text
        out = AES_Encrypt(input, Key)
        out = RC2_Encrypt(out, Key)
        out = XOR_Encrypt(out, Key)
        out = ESAB46_Encode(out)
        Return out.ToString
    End Function
    Public Function EnvY_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim out As String
        input = LogInUserTextBox1.Text
        out = ESAB46_Decode(input)
        out = XOR_Decrypt(out, Key)
        out = RC2_Decrypt(out, Key)
        out = AES_Decrypt(out, Key)
        Return out.ToString
    End Function

    Private Sub LogInButton6_Click(sender As Object, e As EventArgs) Handles LogInButton6.Click
        My.Computer.Clipboard.SetText(LogInUserTextBox1.Text)
    End Sub

    Private Sub LogInButton9_Click(sender As Object, e As EventArgs) Handles LogInButton9.Click
        My.Computer.Clipboard.SetText(LogInUserTextBox2.Text)
    End Sub

    Private Sub LogInButton7_Click(sender As Object, e As EventArgs) Handles LogInButton7.Click
        LogInUserTextBox1.Text = LogInUserTextBox2.Text
    End Sub

    Private Sub LogInButton8_Click(sender As Object, e As EventArgs) Handles LogInButton8.Click
        LogInUserTextBox2.Text = LogInUserTextBox1.Text
    End Sub
#End Region
#End Region
End Class
