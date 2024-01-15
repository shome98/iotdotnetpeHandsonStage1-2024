select distinct(u.Name),u.address
from users u
    
where u.user_id IN
    (select user_id from bookingdetails where Name!="HDFC")
order by u.Name