namespace client.LocalControllers
{
    public static class DialogController
    {
        public static bool ConfirmDelete(string itemName = "Item") => MessageBox.Show($"Deseja mesmo excluir o {itemName}",
                                                                                       "Confirmar ação",
                                                                                       MessageBoxButtons.YesNo) == DialogResult.Yes;

        public static bool ClearData(string DataName = "Valores") => MessageBox.Show($"Deseja mesmo Limpar todos os {DataName}",
                                                                                       "Confirmar ação",
                                                                                       MessageBoxButtons.YesNo) == DialogResult.Yes;

        public static bool ConfirmImport() => MessageBox.Show($"Os registros que já estão no banco de dados serão apenas ignorados\nDeseja continuar?",
                                                              "Confirmar ação",
                                                              MessageBoxButtons.YesNo) == DialogResult.Yes;
    }
}
