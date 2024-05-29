namespace Task3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            throw new Exception("“You tried to use a text\r\ninput in a numeric only field. This fired an error!");
        }
    }
}
