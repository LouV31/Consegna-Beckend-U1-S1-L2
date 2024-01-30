namespace VersioneConsole
{
    internal class Persona
    {

        private string _nome;
        private string _cognome;
        private int _età;

        public Persona(string nome, string cognome, int età)
        {
            this._nome = nome;
            this._cognome = cognome;
            this._età = età;
        }

        public string GetNome()
        {
            return this._nome;
        }

        public string GetCognome()
        {
            return this._cognome;

        }

        public int GetEtà()
        {
            return this._età;
        }

        public string GetDettagli()
        {

            return this._nome + " " + this._cognome + " " + this._età;
        }
    }

}
