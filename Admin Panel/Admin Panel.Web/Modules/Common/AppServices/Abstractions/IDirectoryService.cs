
namespace Admin_Panel;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}