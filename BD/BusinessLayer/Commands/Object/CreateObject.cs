namespace BusinessLayer.Commands.Object
{
    public class CreateObject
    {
        public CreateObject(int clientId, string objectTypeCode, string name, string type)
        {
            ClientId = clientId;
            ObjectTypeCode = objectTypeCode;
            Name = name;
            Type = type;
        }

        public int ClientId { get; private set; }
        public string ObjectTypeCode { get; private set; }
        public string Name { get; private set; }
        public string Type { get; private set; }
    }
}
