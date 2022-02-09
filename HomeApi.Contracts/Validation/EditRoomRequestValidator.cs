using FluentValidation;
using HomeApi.Contracts.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов на редактирование  комнаты
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewArea).NotEmpty();
            RuleFor(x => x.NewName).NotEmpty();
            RuleFor(x => x.NewGasConnected).NotNull();
            RuleFor(x => x.NewVoltage).NotEmpty();
        }

    }
}
