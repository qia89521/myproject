﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiSha.Entity;
using YiSha.Service;
using YiSha.Service.SystemManage;
using YiSha.Entity.SystemManage;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Model;
using YiSha.Util.Model;
using YiSha.Model.Param.SystemManage;
using YiSha.Enum.SystemManage;
using YiSha.Business.Cache;
using YiSha.Enum;

namespace YiSha.Business.SystemManage
{
    public class RoleBLL
    {
        private RoleService roleService = new RoleService();
        private MenuAuthorizeService menuAuthorizeService = new MenuAuthorizeService();

        private MenuAuthorizeCache menuAuthorizeCache = new MenuAuthorizeCache();

        #region 获取数据
        public async Task<TData<List<RoleEntity>>> GetList(RoleListParam param)
        {
            TData<List<RoleEntity>> obj = new TData<List<RoleEntity>>();
            obj.Data = await roleService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }
        /// <summary>
        /// 获取角色列表 根据id串 
        /// </summary>
        /// <param name="ids">id字符串 逗号分隔</param>
        /// <returns></returns>
        public async Task<TData<List<RoleEntity>>> GetList(string ids)
        {
            TData<List<RoleEntity>> obj = new TData<List<RoleEntity>>();
            obj.Data = await roleService.GetList(ids);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }
      
        public async Task<TData<List<RoleEntity>>> GetPageList(RoleListParam param, Pagination pagination)
        {
            TData<List<RoleEntity>> obj = new TData<List<RoleEntity>>();
            obj.Data = await roleService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<RoleEntity>> GetEntity(long id)
        {
            TData<RoleEntity> obj = new TData<RoleEntity>();
            RoleEntity roleEntity = await roleService.GetEntity(id);
            List<MenuAuthorizeEntity> menuAuthorizeList = await menuAuthorizeService.GetList(new MenuAuthorizeEntity
            {
                AuthorizeId = id,
                AuthorizeType = AuthorizeTypeEnum.Role.ParseToInt()
            });
            // 获取角色对应的权限
            roleEntity.MenuIds = string.Join(",", menuAuthorizeList.Select(p => p.MenuId));

            obj.Data = roleEntity;
            obj.Tag = 1;
            return obj;
        }

        /// <summary>
        /// 根据角色代码获取用户
        /// </summary>
        /// <returns></returns>
        public async Task<TData<RoleEntity>> GetEndtityByCode(string code)
        {
            TData<RoleEntity> obj = new TData<RoleEntity>();
            obj.SetDefault();
            RoleEntity roleEntity = await roleService.GetEndtityByCode(code);
            if (roleEntity != null)
            {
                obj.Data = roleEntity;
                obj.Tag = 1;
            }
            else
            {
                obj.Message = "没有该代码的角色";
            }
            return obj;

        }

        /// <summary>
        /// y获取角色代码为用户的角色
        /// </summary>
        /// <returns></returns>
        public async Task<TData<RoleEntity>> GetUserRole()
        {
            TData<RoleEntity> obj = await GetEndtityByCode(SysRoleEnum.normal.ParseToInt().ToString());
            return obj;
        }

        public async Task<TData<int>> GetMaxSort()
        {
            TData<int> obj = new TData<int>();
            obj.Data = await roleService.GetMaxSort();
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(RoleEntity entity)
        {
            TData<string> obj = new TData<string>();

            if (roleService.ExistRoleName(entity))
            {
                obj.Message = "角色名称已经存在！";
                return obj;
            }

            await roleService.SaveForm(entity);

            // 清除缓存里面的权限数据
            menuAuthorizeCache.Remove();

            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;

            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();

            await roleService.DeleteForm(ids);

            // 清除缓存里面的权限数据
            menuAuthorizeCache.Remove();

            obj.Tag = 1;
            return obj;
        }
        #endregion

    }
}
