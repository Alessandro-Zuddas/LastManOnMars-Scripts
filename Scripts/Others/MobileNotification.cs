using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotification : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Remove notifications that alredy have been displayed
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

        //Create the notification channel

        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notifications Channel",
            Importance = Importance.Default,
            Description = "Reminder notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        //Create notifications and parameters
        var notification = new AndroidNotification();
        notification.Title = "Hey! I'm alone here!!!";
        notification.Text = "Let's kick some Martians!";
        notification.FireTime = System.DateTime.Now.AddHours(10);


        //Send the notification
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        //If the script is run and message is alredy scheduled, cancel it and re-schedule another message

        if(AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
