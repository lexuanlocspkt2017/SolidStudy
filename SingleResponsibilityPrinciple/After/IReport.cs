interface IReportRepo
{
    void AddEntryAt(int index);
    void RemoveEntryAt(int index);
}
interface IReportSaver
{
    void SaveToFile(string directoryPath, string fileName);
}