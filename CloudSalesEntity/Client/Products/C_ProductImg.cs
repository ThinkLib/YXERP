﻿/**  版本信息模板在安装目录下，可自行修改。
* C_ProductImg.cs
*
* 功 能： N/A
* 类 名： C_ProductImg
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/5/3 13:38:18   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CloudSalesEntity
{
	/// <summary>
	/// C_ProductImg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class C_ProductImg
	{
		public C_ProductImg()
		{}
		#region Model
		private int _autoid;
		private string _productcode;
		private string _imgs="";
		private string _imgm="";
		private int? _status=1;
		private string _description="";
		private string _createuserid;
		private DateTime? _createtime= DateTime.Now;
		private DateTime? _updatetime= DateTime.Now;
		private string _operateip="";
		private string _clientid;
		/// <summary>
		/// 
		/// </summary>
		public int AutoID
		{
			set{ _autoid=value;}
			get{return _autoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProductCode
		{
			set{ _productcode=value;}
			get{return _productcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgS
		{
			set{ _imgs=value;}
			get{return _imgs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgM
		{
			set{ _imgm=value;}
			get{return _imgm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateUserID
		{
			set{ _createuserid=value;}
			get{return _createuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OperateIP
		{
			set{ _operateip=value;}
			get{return _operateip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ClientID
		{
			set{ _clientid=value;}
			get{return _clientid;}
		}
		#endregion Model

	}
}

