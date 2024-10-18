namespace client.LocalControllers
{
    public static class DialogController
    {
        public static bool ConfirmDelete(string itemName = "Item") => MessageBox.Show($"Deseja mesmo excluir o {itemName}",
                                                                                       "Confirmar ação",
                                                                                       MessageBoxButtons.YesNo) == DialogResult.Yes;
    }
}
