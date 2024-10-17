using Application.Services.Interface.Server;
using Domain.DTOs.Product;
using Domain.Entities.Product;
using Domain.Entities.Server;
using Domain.Entities.Vpn;
using Domain.Enums.Product;
using Domain.IRepositories.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using Application.Extensions;
using Application.Services.Implementation.Agent;
using Application.Utilities;
using Domain.DTOs.Vpn;
using Domain.Entities.Account;
using Domain.Enums.Vpn;
using Domain.IRepositories.Account;
using Domain.IRepositories.Category;
using Domain.IRepositories.Vpn;
using Application.Helper;
using Application.Utilities;
using Application.Services.Interface.Product;
using Application.Services.Interface.Vpn;
using Application.Services.Interface.Agent;
using Domain.Exceptions;

namespace Application.Services.Implementation.Product;

// public class ProductService(IProductRepository productRepository, IServerService serverService, IVpnService vpnService)
public class ProductService(
    IProductRepository productRepository,
    IUserRepository userRepository,
    IAgentService agentService,
    ICategoryRepository categoryRepository,
    IVpnService vpnService
)
    : IProductService
{
    #region add

    public async Task<AddVpnProductResult> AddVpnProductAsync(AddVpnProductDto product, long userId)
    {
        await using IDbContextTransaction
            transaction = await productRepository.context.Database.BeginTransactionAsync();

        Domain.Entities.Vpn.Vpn? vpn = await vpnService.AddVpnAsync(product.VpnDto, userId);

        if (vpn is null) return AddVpnProductResult.ServerNotExists;

        Domain.Entities.Product.Product newProduct = new()
        {
            CategoryId = product.CategoryId,
            Description = product.Description,
            ProductName = product.ProductName,
            Price = product.Price,
        };

        if (product.Avatar != null && product.Avatar.IsImage())
        {
            // var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(product.Avatar.FileName);
            // product.Avatar.AddImageToServer(imageName, PathExtension.ProductAvatarOriginServer, 500, 500,
            //     PathExtension.ProductAvatarThumbServer);
            // newProduct.ProductImage = imageName;
        }

        await productRepository.AddEntity(newProduct);
        await productRepository.SaveChanges(userId);

        await transaction.CommitAsync();

        return AddVpnProductResult.Success;
    }

    public async Task<AddProductResult> AddProductAsync(AddProductDto product, long userId)
    {
        using IDbContextTransaction transaction = await productRepository.context.Database.BeginTransactionAsync();

        Domain.Entities.Category.Category? category = await categoryRepository.GetEntityById(product.CategoryId);

        if (category is null)
            throw new NotFoundException("چنین دسته بندی وجود ندارد");

        Domain.Entities.Product.Product newProduct = new()
        {
            CategoryId = product.CategoryId,
            Description = product.Description,
            ProductName = product.ProductName,
            Price = product.Price,
            IsDelete = false
        };

        await productRepository.AddEntity(newProduct);
        await productRepository.SaveChanges(userId);

        await transaction.CommitAsync();

        return AddProductResult.Success;
    }

    #endregion

    #region get

    public async Task<List<ProductDto>> GetProductAsync()
    {
        return await productRepository.GetQuery()
            .Include(x => x.Category)
            .Select(x => new ProductDto()
            {
                CategoryType = x.Category.CategoryType,
                ProductName = x.ProductName,
                Description = x.Description,
                Price = x.Price,
                Id = x.Id
            }).ToListAsync();
    }

    public async Task<List<ProductDto>> GetProductByCategoryIdAsync(long categoryId)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductDto> GetProductByIdAsync(long productId)
    {
        Domain.Entities.Product.Product? product = await productRepository.GetEntityById(productId);

        if (product is null) throw new NotFoundException("چنین محصولی وجود ندارد");

        return new()
        {
            Id = product.Id,
            Price = product.Price,
            Description = product.Description,
            ProductName = product.ProductName,
            ProductImage = product.ProductImage,
            CategoryId = product.CategoryId,
        };
    }

    public async Task<FilterProductDto> FilterProductAsync(FilterProductDto filter, long userId)
    {
        IQueryable<Domain.Entities.Product.Product> query = productRepository.GetQuery();

        if (filter.CategoryId != null && filter.CategoryId != 0)
            query = query.Where(x => x.CategoryId == filter.CategoryId);

        if (!string.IsNullOrEmpty(filter.ProductName))
            query = query.Where(x => EF.Functions.Like(x.ProductName!, $"%{filter.ProductName}%"));

        IQueryable<ProductDto> products = query.Select(x => new ProductDto()
        {
            CategoryId = x.CategoryId,
            Description = x.Description,
            Price = x.Price,
            ProductImage = x.ProductImage,
            ProductName = x.ProductName,
        });

        await filter.Paging(products);

        User? user = await userRepository.GetEntityById(userId);

        if (user == null) throw new NotFoundException("کاربری با این شناسه یافت نشد");

        var agentIds = await agentService.GetAgentRoot(user.AgentId);

        // using Percent percent = new(agentService);

        // foreach (ProductDto? entity in filter.Entities)
        // {
        //     entity.Price = await percent.Calculate(agentIds, entity.Price);
        // }

        return filter;
    }

    #endregion
}