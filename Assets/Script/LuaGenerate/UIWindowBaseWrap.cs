﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UIWindowBaseWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UIWindowBase), typeof(UIBase));
		L.RegFunction("OnOpen", OnOpen);
		L.RegFunction("OnClose", OnClose);
		L.RegFunction("OnHide", OnHide);
		L.RegFunction("OnShow", OnShow);
		L.RegFunction("OnRefresh", OnRefresh);
		L.RegFunction("EnterAnim", EnterAnim);
		L.RegFunction("OnCompleteEnterAnim", OnCompleteEnterAnim);
		L.RegFunction("ExitAnim", ExitAnim);
		L.RegFunction("OnCompleteExitAnim", OnCompleteExitAnim);
		L.RegFunction("Show", Show);
		L.RegFunction("Hide", Hide);
		L.RegFunction("Refresh", Refresh);
		L.RegFunction("AddEventListener", AddEventListener);
		L.RegFunction("RemoveAllListener", RemoveAllListener);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m_UIType", get_m_UIType, set_m_UIType);
		L.RegVar("m_bgMask", get_m_bgMask, set_m_bgMask);
		L.RegVar("m_uiRoot", get_m_uiRoot, set_m_uiRoot);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnOpen(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnOpen();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnClose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnClose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnHide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnHide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnShow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnShow();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRefresh(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnRefresh();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnterAnim(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			UIAnimCallBack arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UIAnimCallBack)ToLua.CheckObject(L, 2, typeof(UIAnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UIAnimCallBack), func) as UIAnimCallBack;
			}

			UICallBack arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (UICallBack)ToLua.CheckObject(L, 3, typeof(UICallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(UICallBack), func) as UICallBack;
			}

			object[] arg2 = ToLua.ToParamsObject(L, 4, count - 3);
			System.Collections.IEnumerator o = obj.EnterAnim(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCompleteEnterAnim(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnCompleteEnterAnim();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExitAnim(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			UIAnimCallBack arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UIAnimCallBack)ToLua.CheckObject(L, 2, typeof(UIAnimCallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UIAnimCallBack), func) as UIAnimCallBack;
			}

			UICallBack arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (UICallBack)ToLua.CheckObject(L, 3, typeof(UICallBack));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(UICallBack), func) as UICallBack;
			}

			object[] arg2 = ToLua.ToParamsObject(L, 4, count - 3);
			System.Collections.IEnumerator o = obj.ExitAnim(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCompleteExitAnim(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.OnCompleteExitAnim();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Show(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.Show();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Hide(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.Hide();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Refresh(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
			obj.Refresh(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEventListener(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UIWindowBase), typeof(System.Enum)))
			{
				UIWindowBase obj = (UIWindowBase)ToLua.ToObject(L, 1);
				System.Enum arg0 = (System.Enum)ToLua.ToObject(L, 2);
				obj.AddEventListener(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UIWindowBase), typeof(System.Enum), typeof(EventHandle)))
			{
				UIWindowBase obj = (UIWindowBase)ToLua.ToObject(L, 1);
				System.Enum arg0 = (System.Enum)ToLua.ToObject(L, 2);
				EventHandle arg1 = null;
				LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

				if (funcType3 != LuaTypes.LUA_TFUNCTION)
				{
					 arg1 = (EventHandle)ToLua.ToObject(L, 3);
				}
				else
				{
					LuaFunction func = ToLua.ToLuaFunction(L, 3);
					arg1 = DelegateFactory.CreateDelegate(typeof(EventHandle), func) as EventHandle;
				}

				obj.AddEventListener(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UIWindowBase.AddEventListener");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveAllListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UIWindowBase obj = (UIWindowBase)ToLua.CheckObject(L, 1, typeof(UIWindowBase));
			obj.RemoveAllListener();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_UIType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UIType ret = obj.m_UIType;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_UIType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_bgMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UnityEngine.GameObject ret = obj.m_bgMask;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_bgMask on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_uiRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UnityEngine.GameObject ret = obj.m_uiRoot;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_uiRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_UIType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UIType arg0 = (UIType)ToLua.CheckObject(L, 2, typeof(UIType));
			obj.m_UIType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_UIType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_bgMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.m_bgMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_bgMask on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_uiRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UIWindowBase obj = (UIWindowBase)o;
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			obj.m_uiRoot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_uiRoot on a nil value" : e.Message);
		}
	}
}
