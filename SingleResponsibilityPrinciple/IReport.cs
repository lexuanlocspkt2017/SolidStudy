interface IReport
{
    void AddEntryAt(int index);
    void RemoveEntryAt(int index);
    void SaveToFile(string directoryPath, string fileName);
}