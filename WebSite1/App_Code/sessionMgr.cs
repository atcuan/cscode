using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///sessionMgr 的摘要说明
/// </summary>
public class sessionMgr
{
	private static IDictionary<string,IDictionary<string,object>> data = new Dictionary<string,IDictionary<string,object>>();

    public IDictionary<string, object> getSession(string sessionId)
    {
        if (data.ContainsKey(sessionId))
        {
            return data[sessionId];
        }
        else
        {
            IDictionary<string,object> session = new Dictionary<string,object>();
            data[sessionId] = session;
            return session;
        }
    }

    public static IDictionary<string, object> GetSession(string sessionId)
    {
        throw new NotImplementedException();
    }
}
