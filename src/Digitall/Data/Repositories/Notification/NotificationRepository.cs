using Data.Context;
using Data.Repositories.Base;
using Domain.IRepositories.Notification;

namespace Data.Repositories.Notification;

public class NotificationRepository(DigitallDbContext context) :
    BaseRepository<Domain.Entities.Notification.Notification>(context), INotificationRepository;