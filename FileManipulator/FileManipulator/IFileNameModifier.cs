namespace FileManipulator
{
    public interface IFileNameModifier
    {
        void ModifyFileNames(string stringModifier);
        string ModifierType { get; }
    }
}