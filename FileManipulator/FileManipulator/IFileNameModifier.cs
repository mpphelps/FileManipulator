namespace FileManipulator
{
    partial class Program
    {
        public interface IFileNameModifier
        {
            void ModifyFileNames(string stringModifier);
        }
    }
}