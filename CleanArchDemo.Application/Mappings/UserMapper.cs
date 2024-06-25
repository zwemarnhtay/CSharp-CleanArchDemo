using CleanArchDemo.Application.DTOs;
using CleanArchDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchDemo.Application.Mappings;

public static class UserMapper
{
    public static UserDTO ToDTO(this User user)
    {
        return new UserDTO
        {
            Id = user.UserId,
            Name = user.Name,
            Address = user.Address,
            Phone = user.Phone,
            Role = user.Role,
            Email = user.Email,
        };
    }

    public static User ToEntity(this UserDTO userDto)
    {
        return new User
        {
            UserId = userDto.Id,
            Name = userDto.Name,
            Address = userDto.Address,
            Phone = userDto.Phone,
            Role = userDto.Role,
            Email = userDto.Email,
        };
    }
}
