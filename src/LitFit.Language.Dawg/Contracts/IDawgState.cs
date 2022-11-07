using System.IO;

namespace LitFit.Language.Dawg
{
    public interface IDawgState
    {
        int Length { get; }
        IDawgReader GetReader();
        void Write(BinaryWriter writer);
        void Read(BinaryReader reader);
    }
}