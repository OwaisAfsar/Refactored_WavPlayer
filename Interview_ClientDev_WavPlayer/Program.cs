using System;
using System.Windows.Forms;

namespace Interview_ClientDev_WavPlayer
{
    /// <summary>
    /// Dieses Programm soll einen simplen WAV-Player darstellen.
    /// Das Programm wurde bewusst in einem schlechten Stil programmiert.
    /// Ihre Aufgaben sind:
    /// -Refactoring des gesamten Codes (Stichwörter Clean Code, SOLID, Architektur)
    /// -Testabdeckung des gesamten resultierenden Codes
    /// -Verbesserung des Codes an offensichtlichen Stellen
    /// -Versuchen Sie das Programm in einem bestmöglichen Zustand abzugeben
    /// -Dokumentieren Sie bitte Ihre aufgewendete Zeit
    /// -Übermitteln Sie den finalen Code 2 Arbeitstage vor dem nächsten Vorstellungsgespräch
    /// -Im nächsten Vorstellungsgespräch stellen Sie Ihre Lösung vor
    /// Wenn Sie Fragen haben, melden Sie sich gerne via Mail.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleWavPlayer());
        }
    }
}
