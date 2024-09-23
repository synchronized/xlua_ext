using UnityEngine;
using XLua;
using XLua.LuaDLL;

namespace XLuaTest
{

    public class ThirdpartLib : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            LuaEnv luaenv = new LuaEnv();
            luaenv.AddBuildin("cjson", Lua.LoadCjson);
            luaenv.AddBuildin("cjson.safe", Lua.LoadCjsonSafe);
            luaenv.AddBuildin("lpeg", Lua.LoadLpeg);

            luaenv.AddBuildin("pb", Lua.LoadPb);
            luaenv.AddBuildin("pb.io", Lua.LoadPbIo);
            luaenv.AddBuildin("pb.conv", Lua.LoadPbConv);
            luaenv.AddBuildin("pb.buffer", Lua.LoadPbBuffer);
            luaenv.AddBuildin("pb.slice", Lua.LoadPbSlice);
            luaenv.AddBuildin("pb.unsafe", Lua.LoadPbUnsafe);

            luaenv.AddBuildin("rapidjson", Lua.LoadRapidJson);
            luaenv.AddBuildin("crypt", Lua.LoadCrypt);
            luaenv.AddBuildin("sproto.core", Lua.LoadSprotoCore);

            luaenv.DoString("require 'cjson'");
            luaenv.DoString("require 'cjson.safe'");
            luaenv.DoString("require 'lpeg'");

            luaenv.DoString("require 'pb'");
            luaenv.DoString("require 'pb.io'");
            luaenv.DoString("require 'pb.conv'");
            luaenv.DoString("require 'pb.buffer'");
            luaenv.DoString("require 'pb.slice'");
            luaenv.DoString("require 'pb.unsafe'");

            luaenv.DoString("require 'rapidjson'");
            luaenv.DoString("require 'crypt'");
            luaenv.DoString("require 'sproto.core'");
            luaenv.Dispose();

            UnityEngine.Debug.Log("XLuaConfig.RootPath:"+XLuaConfig.RootPath);
            UnityEngine.Debug.Log("XLuaConfig.GenCSPath:"+XLuaConfig.GenCSPath);
            UnityEngine.Debug.Log("XLuaConfig.GenLuaPath:"+XLuaConfig.GenLuaPath);
            UnityEngine.Debug.Log("XLuaConfig.AssetGenLuaPath:"+XLuaConfig.AssetGenLuaPath);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

}