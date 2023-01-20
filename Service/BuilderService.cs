namespace Radar_Api.Service;

public class BuilderService<T>
{
    public static T Builder(object objectDTO)
    {
        var obj = Activator.CreateInstance<T>();

        foreach(var propDTO in objectDTO.GetType().GetProperties())
        {
            var propObj = obj?.GetType().GetProperty(propDTO.Name);
            if(propObj is not null)
            {
                propObj.SetValue(obj, propDTO.GetValue(objectDTO));
            }
        }

        return obj;
    }

}