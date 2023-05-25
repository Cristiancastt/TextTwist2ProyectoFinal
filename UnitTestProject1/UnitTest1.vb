Imports System.IO
Imports System.Text
Imports ClasesJuego, TextTwist2
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1
    Dim juego As New Juego
    Private ReadOnly directorioPrueba As String = "../.././Ficheros/"

    <TestMethod()>
    Public Sub TestExistenFicheros()
        Dim result = juego.extraerPalabras()
        Assert.IsNull(result, "Se espera que sea null por que C: no contiene ficheros.txt")
    End Sub
    <TestMethod()>
    Public Sub TestRegistro()
        Dim result = register("", "")
        Assert.IsFalse(result, "Se espera que sea false por que registra un usuario vacio")
    End Sub
    <TestMethod()>
    Public Sub TestLogin()
        Dim result = login("", "")
        Assert.IsFalse(result, "Se espera que sea false por que logea un usuario vacio")
    End Sub

    <TestMethod()>
    Public Sub TestFicherosIguales()
        Dim archivoConfiguracion As String = Path.Combine(directorioPrueba, "configuracion.txt")
        Dim datosConfiguracion As String = "Cristian, 1234, 1212120" & Environment.NewLine &
                                          "Asiermmg, 1234, 9999990" & Environment.NewLine &
                                          "ElenaLuz, P@ssw0rd, 4240"
        File.WriteAllText(archivoConfiguracion, datosConfiguracion)
        Dim lineas() As String = File.ReadAllLines(archivoConfiguracion)
        Assert.AreEqual("Cristian, 1234, 1212120", lineas(0))
        Assert.AreEqual("Asiermmg, 1234, 9999990", lineas(1))
        Assert.AreEqual("ElenaLuz, P@ssw0rd, 4240", lineas(2))
    End Sub
    <TestMethod()>
    Public Sub TestSondio()
        Dim result = sonidoActivo()
        Assert.IsTrue(result, "Se espera que sea true por que el sonido empieza activado.")
    End Sub

End Class