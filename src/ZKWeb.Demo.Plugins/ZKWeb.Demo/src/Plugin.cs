﻿using ZKWeb.Plugin;
using ZKWeb.Templating.DynamicContents;
using ZKWebStandard.Ioc;

namespace ZKWeb.Demo.Plugins.ZKWeb.Demo.src {
	/// <summary>
	/// 载入插件时的处理
	/// </summary>
	[ExportMany, SingletonReuse]
	public class Plugin : IPlugin {
		/// <summary>
		/// 初始化
		/// </summary>
		public Plugin() {
			// 注册默认模块
			var areaManager = Application.Ioc.Resolve<TemplateAreaManager>();
			areaManager.GetArea("index_top_area_1").DefaultWidgets.Add("demo.widgets/demo_index");
			areaManager.GetArea("header_menubar").DefaultWidgets.Add("demo.widgets/demo_nav_menu");
		}
	}
}
