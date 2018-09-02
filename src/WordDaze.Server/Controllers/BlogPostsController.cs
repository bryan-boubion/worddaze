using WordDaze.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WordDaze.Server.Controllers
{
    public class BlogPostsController : Controller
    {
        private List<BlogPost> _blogPosts { get; set; } = new List<BlogPost> {
            new BlogPost {
                Id = 1,
                Title = "If only C# worked in the browser",
                Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec pulvinar mi, ut aliquam urna. Vivamus non erat libero. Proin eleifend arcu nulla, nec luctus magna maximus in. Morbi viverra enim eu mauris ultricies efficitur. Vestibulum eget turpis ut elit semper bibendum eu vel odio. Phasellus sit amet molestie purus, in suscipit dolor. Mauris semper risus eget turpis aliquam egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget sem a odio luctus molestie eget et nunc. Vestibulum dapibus tincidunt lectus et facilisis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean elit leo, sagittis id suscipit sed, mollis et enim. Nam aliquam imperdiet leo, nec vestibulum mi sollicitudin in. Donec suscipit augue nec lacus lobortis semper. Vivamus sollicitudin justo erat, vel ornare erat finibus a. Quisque nec sodales augue. Donec porttitor lacus ut justo laoreet, at molestie magna tincidunt. In dictum purus at lectus porta sodales. Aliquam iaculis varius vehicula. In sollicitudin faucibus magna a rutrum. Proin vestibulum nulla ante. Proin eget mauris eleifend, dignissim nulla sit amet, auctor sapien. Phasellus eget orci mi. Suspendisse placerat, neque dapibus laoreet ornare, enim arcu consequat sem, at convallis ligula mi quis tortor. Mauris id nunc id diam cursus tincidunt nec ultrices risus. Phasellus ipsum orci, interdum sit amet lacus a, commodo ultrices leo. Mauris lacinia quis metus vel maximus. In rhoncus tristique risus, sed rhoncus turpis hendrerit ut. Nunc nulla quam, auctor non tortor vel, suscipit cursus nunc. Quisque et elementum neque, et condimentum odio. Suspendisse facilisis ac diam quis lobortis. Nam scelerisque eros felis, id tincidunt metus mollis sit amet. Mauris leo massa, vestibulum id libero sit amet, cursus maximus turpis. Mauris tortor ante, tincidunt quis porta eu, egestas eu tellus. Aliquam nulla mi, condimentum sit amet sem sit amet, pulvinar tincidunt arcu. Nunc lorem eros, consequat a dui non, tempus porttitor orci. Etiam semper rhoncus nulla sed efficitur. In vitae urna arcu. Curabitur arcu sem, rhoncus sit amet cursus id, facilisis sit amet justo. Praesent mollis nulla pulvinar nunc efficitur hendrerit. Ut eget purus metus. Vivamus ullamcorper massa sit amet aliquam cursus. Vestibulum iaculis maximus velit sit amet consequat. Quisque at lorem sit amet arcu ullamcorper tincidunt nec at diam. Morbi imperdiet, turpis sed lacinia finibus, nunc metus vestibulum elit, a finibus nunc enim id lorem. Mauris facilisis enim nec eros consequat, vel ultricies libero feugiat. Aliquam at tempus ipsum. Phasellus vulputate porttitor felis, ac suscipit felis dictum id. Fusce iaculis, mauris ac pharetra volutpat, orci lacus tempor leo, sed mattis felis ante at turpis. Sed dapibus lobortis est a sollicitudin. Nam cursus ipsum non tincidunt fermentum. Nulla sagittis sed enim ut ornare. Nam ornare libero ligula, non tincidunt nibh laoreet non. In hendrerit sapien metus, elementum tempor ligula volutpat sed. Vivamus eget varius leo. Sed quis mattis erat, non vulputate augue. Sed egestas rutrum neque, sed commodo nisi euismod in. Quisque dapibus lacus eu nunc congue, ut dapibus risus consectetur. Praesent nec dui et ex porta sagittis eu et justo. Suspendisse rhoncus ipsum eu aliquam eleifend. Fusce lobortis eleifend volutpat. Maecenas vehicula ultrices justo sed rutrum.",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-30)
            },
            new BlogPost { 
                Id = 2, 
                Title = "400th JS Framework released", 
                Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec pulvinar mi, ut aliquam urna. Vivamus non erat libero. Proin eleifend arcu nulla, nec luctus magna maximus in. Morbi viverra enim eu mauris ultricies efficitur. Vestibulum eget turpis ut elit semper bibendum eu vel odio. Phasellus sit amet molestie purus, in suscipit dolor. Mauris semper risus eget turpis aliquam egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget sem a odio luctus molestie eget et nunc. Vestibulum dapibus tincidunt lectus et facilisis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean elit leo, sagittis id suscipit sed, mollis et enim. Nam aliquam imperdiet leo, nec vestibulum mi sollicitudin in. Donec suscipit augue nec lacus lobortis semper. Vivamus sollicitudin justo erat, vel ornare erat finibus a. Quisque nec sodales augue. Donec porttitor lacus ut justo laoreet, at molestie magna tincidunt. In dictum purus at lectus porta sodales. Aliquam iaculis varius vehicula. In sollicitudin faucibus magna a rutrum. Proin vestibulum nulla ante. Proin eget mauris eleifend, dignissim nulla sit amet, auctor sapien. Phasellus eget orci mi. Suspendisse placerat, neque dapibus laoreet ornare, enim arcu consequat sem, at convallis ligula mi quis tortor. Mauris id nunc id diam cursus tincidunt nec ultrices risus. Phasellus ipsum orci, interdum sit amet lacus a, commodo ultrices leo. Mauris lacinia quis metus vel maximus. In rhoncus tristique risus, sed rhoncus turpis hendrerit ut. Nunc nulla quam, auctor non tortor vel, suscipit cursus nunc. Quisque et elementum neque, et condimentum odio. Suspendisse facilisis ac diam quis lobortis. Nam scelerisque eros felis, id tincidunt metus mollis sit amet. Mauris leo massa, vestibulum id libero sit amet, cursus maximus turpis. Mauris tortor ante, tincidunt quis porta eu, egestas eu tellus. Aliquam nulla mi, condimentum sit amet sem sit amet, pulvinar tincidunt arcu. Nunc lorem eros, consequat a dui non, tempus porttitor orci. Etiam semper rhoncus nulla sed efficitur. In vitae urna arcu. Curabitur arcu sem, rhoncus sit amet cursus id, facilisis sit amet justo. Praesent mollis nulla pulvinar nunc efficitur hendrerit. Ut eget purus metus. Vivamus ullamcorper massa sit amet aliquam cursus. Vestibulum iaculis maximus velit sit amet consequat. Quisque at lorem sit amet arcu ullamcorper tincidunt nec at diam. Morbi imperdiet, turpis sed lacinia finibus, nunc metus vestibulum elit, a finibus nunc enim id lorem. Mauris facilisis enim nec eros consequat, vel ultricies libero feugiat. Aliquam at tempus ipsum. Phasellus vulputate porttitor felis, ac suscipit felis dictum id. Fusce iaculis, mauris ac pharetra volutpat, orci lacus tempor leo, sed mattis felis ante at turpis. Sed dapibus lobortis est a sollicitudin. Nam cursus ipsum non tincidunt fermentum. Nulla sagittis sed enim ut ornare. Nam ornare libero ligula, non tincidunt nibh laoreet non. In hendrerit sapien metus, elementum tempor ligula volutpat sed. Vivamus eget varius leo. Sed quis mattis erat, non vulputate augue. Sed egestas rutrum neque, sed commodo nisi euismod in. Quisque dapibus lacus eu nunc congue, ut dapibus risus consectetur. Praesent nec dui et ex porta sagittis eu et justo. Suspendisse rhoncus ipsum eu aliquam eleifend. Fusce lobortis eleifend volutpat. Maecenas vehicula ultrices justo sed rutrum.",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-25)
            },
            new BlogPost { 
                Id = 3, 
                Title = "WebAssembly FTW", 
                Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec pulvinar mi, ut aliquam urna. Vivamus non erat libero. Proin eleifend arcu nulla, nec luctus magna maximus in. Morbi viverra enim eu mauris ultricies efficitur. Vestibulum eget turpis ut elit semper bibendum eu vel odio. Phasellus sit amet molestie purus, in suscipit dolor. Mauris semper risus eget turpis aliquam egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget sem a odio luctus molestie eget et nunc. Vestibulum dapibus tincidunt lectus et facilisis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean elit leo, sagittis id suscipit sed, mollis et enim. Nam aliquam imperdiet leo, nec vestibulum mi sollicitudin in. Donec suscipit augue nec lacus lobortis semper. Vivamus sollicitudin justo erat, vel ornare erat finibus a. Quisque nec sodales augue. Donec porttitor lacus ut justo laoreet, at molestie magna tincidunt. In dictum purus at lectus porta sodales. Aliquam iaculis varius vehicula. In sollicitudin faucibus magna a rutrum. Proin vestibulum nulla ante. Proin eget mauris eleifend, dignissim nulla sit amet, auctor sapien. Phasellus eget orci mi. Suspendisse placerat, neque dapibus laoreet ornare, enim arcu consequat sem, at convallis ligula mi quis tortor. Mauris id nunc id diam cursus tincidunt nec ultrices risus. Phasellus ipsum orci, interdum sit amet lacus a, commodo ultrices leo. Mauris lacinia quis metus vel maximus. In rhoncus tristique risus, sed rhoncus turpis hendrerit ut. Nunc nulla quam, auctor non tortor vel, suscipit cursus nunc. Quisque et elementum neque, et condimentum odio. Suspendisse facilisis ac diam quis lobortis. Nam scelerisque eros felis, id tincidunt metus mollis sit amet. Mauris leo massa, vestibulum id libero sit amet, cursus maximus turpis. Mauris tortor ante, tincidunt quis porta eu, egestas eu tellus. Aliquam nulla mi, condimentum sit amet sem sit amet, pulvinar tincidunt arcu. Nunc lorem eros, consequat a dui non, tempus porttitor orci. Etiam semper rhoncus nulla sed efficitur. In vitae urna arcu. Curabitur arcu sem, rhoncus sit amet cursus id, facilisis sit amet justo. Praesent mollis nulla pulvinar nunc efficitur hendrerit. Ut eget purus metus. Vivamus ullamcorper massa sit amet aliquam cursus. Vestibulum iaculis maximus velit sit amet consequat. Quisque at lorem sit amet arcu ullamcorper tincidunt nec at diam. Morbi imperdiet, turpis sed lacinia finibus, nunc metus vestibulum elit, a finibus nunc enim id lorem. Mauris facilisis enim nec eros consequat, vel ultricies libero feugiat. Aliquam at tempus ipsum. Phasellus vulputate porttitor felis, ac suscipit felis dictum id. Fusce iaculis, mauris ac pharetra volutpat, orci lacus tempor leo, sed mattis felis ante at turpis. Sed dapibus lobortis est a sollicitudin. Nam cursus ipsum non tincidunt fermentum. Nulla sagittis sed enim ut ornare. Nam ornare libero ligula, non tincidunt nibh laoreet non. In hendrerit sapien metus, elementum tempor ligula volutpat sed. Vivamus eget varius leo. Sed quis mattis erat, non vulputate augue. Sed egestas rutrum neque, sed commodo nisi euismod in. Quisque dapibus lacus eu nunc congue, ut dapibus risus consectetur. Praesent nec dui et ex porta sagittis eu et justo. Suspendisse rhoncus ipsum eu aliquam eleifend. Fusce lobortis eleifend volutpat. Maecenas vehicula ultrices justo sed rutrum.",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-20)
            },
            new BlogPost { 
                Id = 4, 
                Title = "Blazor is Awesome!", 
                Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec pulvinar mi, ut aliquam urna. Vivamus non erat libero. Proin eleifend arcu nulla, nec luctus magna maximus in. Morbi viverra enim eu mauris ultricies efficitur. Vestibulum eget turpis ut elit semper bibendum eu vel odio. Phasellus sit amet molestie purus, in suscipit dolor. Mauris semper risus eget turpis aliquam egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget sem a odio luctus molestie eget et nunc. Vestibulum dapibus tincidunt lectus et facilisis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean elit leo, sagittis id suscipit sed, mollis et enim. Nam aliquam imperdiet leo, nec vestibulum mi sollicitudin in. Donec suscipit augue nec lacus lobortis semper. Vivamus sollicitudin justo erat, vel ornare erat finibus a. Quisque nec sodales augue. Donec porttitor lacus ut justo laoreet, at molestie magna tincidunt. In dictum purus at lectus porta sodales. Aliquam iaculis varius vehicula. In sollicitudin faucibus magna a rutrum. Proin vestibulum nulla ante. Proin eget mauris eleifend, dignissim nulla sit amet, auctor sapien. Phasellus eget orci mi. Suspendisse placerat, neque dapibus laoreet ornare, enim arcu consequat sem, at convallis ligula mi quis tortor. Mauris id nunc id diam cursus tincidunt nec ultrices risus. Phasellus ipsum orci, interdum sit amet lacus a, commodo ultrices leo. Mauris lacinia quis metus vel maximus. In rhoncus tristique risus, sed rhoncus turpis hendrerit ut. Nunc nulla quam, auctor non tortor vel, suscipit cursus nunc. Quisque et elementum neque, et condimentum odio. Suspendisse facilisis ac diam quis lobortis. Nam scelerisque eros felis, id tincidunt metus mollis sit amet. Mauris leo massa, vestibulum id libero sit amet, cursus maximus turpis. Mauris tortor ante, tincidunt quis porta eu, egestas eu tellus. Aliquam nulla mi, condimentum sit amet sem sit amet, pulvinar tincidunt arcu. Nunc lorem eros, consequat a dui non, tempus porttitor orci. Etiam semper rhoncus nulla sed efficitur. In vitae urna arcu. Curabitur arcu sem, rhoncus sit amet cursus id, facilisis sit amet justo. Praesent mollis nulla pulvinar nunc efficitur hendrerit. Ut eget purus metus. Vivamus ullamcorper massa sit amet aliquam cursus. Vestibulum iaculis maximus velit sit amet consequat. Quisque at lorem sit amet arcu ullamcorper tincidunt nec at diam. Morbi imperdiet, turpis sed lacinia finibus, nunc metus vestibulum elit, a finibus nunc enim id lorem. Mauris facilisis enim nec eros consequat, vel ultricies libero feugiat. Aliquam at tempus ipsum. Phasellus vulputate porttitor felis, ac suscipit felis dictum id. Fusce iaculis, mauris ac pharetra volutpat, orci lacus tempor leo, sed mattis felis ante at turpis. Sed dapibus lobortis est a sollicitudin. Nam cursus ipsum non tincidunt fermentum. Nulla sagittis sed enim ut ornare. Nam ornare libero ligula, non tincidunt nibh laoreet non. In hendrerit sapien metus, elementum tempor ligula volutpat sed. Vivamus eget varius leo. Sed quis mattis erat, non vulputate augue. Sed egestas rutrum neque, sed commodo nisi euismod in. Quisque dapibus lacus eu nunc congue, ut dapibus risus consectetur. Praesent nec dui et ex porta sagittis eu et justo. Suspendisse rhoncus ipsum eu aliquam eleifend. Fusce lobortis eleifend volutpat. Maecenas vehicula ultrices justo sed rutrum.",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-15)
            },
            new BlogPost { 
                Id = 5, 
                Title = "Your first Blazor App", 
                Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In nec pulvinar mi, ut aliquam urna. Vivamus non erat libero. Proin eleifend arcu nulla, nec luctus magna maximus in. Morbi viverra enim eu mauris ultricies efficitur. Vestibulum eget turpis ut elit semper bibendum eu vel odio. Phasellus sit amet molestie purus, in suscipit dolor. Mauris semper risus eget turpis aliquam egestas. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse eget sem a odio luctus molestie eget et nunc. Vestibulum dapibus tincidunt lectus et facilisis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean elit leo, sagittis id suscipit sed, mollis et enim. Nam aliquam imperdiet leo, nec vestibulum mi sollicitudin in. Donec suscipit augue nec lacus lobortis semper. Vivamus sollicitudin justo erat, vel ornare erat finibus a. Quisque nec sodales augue. Donec porttitor lacus ut justo laoreet, at molestie magna tincidunt. In dictum purus at lectus porta sodales. Aliquam iaculis varius vehicula. In sollicitudin faucibus magna a rutrum. Proin vestibulum nulla ante. Proin eget mauris eleifend, dignissim nulla sit amet, auctor sapien. Phasellus eget orci mi. Suspendisse placerat, neque dapibus laoreet ornare, enim arcu consequat sem, at convallis ligula mi quis tortor. Mauris id nunc id diam cursus tincidunt nec ultrices risus. Phasellus ipsum orci, interdum sit amet lacus a, commodo ultrices leo. Mauris lacinia quis metus vel maximus. In rhoncus tristique risus, sed rhoncus turpis hendrerit ut. Nunc nulla quam, auctor non tortor vel, suscipit cursus nunc. Quisque et elementum neque, et condimentum odio. Suspendisse facilisis ac diam quis lobortis. Nam scelerisque eros felis, id tincidunt metus mollis sit amet. Mauris leo massa, vestibulum id libero sit amet, cursus maximus turpis. Mauris tortor ante, tincidunt quis porta eu, egestas eu tellus. Aliquam nulla mi, condimentum sit amet sem sit amet, pulvinar tincidunt arcu. Nunc lorem eros, consequat a dui non, tempus porttitor orci. Etiam semper rhoncus nulla sed efficitur. In vitae urna arcu. Curabitur arcu sem, rhoncus sit amet cursus id, facilisis sit amet justo. Praesent mollis nulla pulvinar nunc efficitur hendrerit. Ut eget purus metus. Vivamus ullamcorper massa sit amet aliquam cursus. Vestibulum iaculis maximus velit sit amet consequat. Quisque at lorem sit amet arcu ullamcorper tincidunt nec at diam. Morbi imperdiet, turpis sed lacinia finibus, nunc metus vestibulum elit, a finibus nunc enim id lorem. Mauris facilisis enim nec eros consequat, vel ultricies libero feugiat. Aliquam at tempus ipsum. Phasellus vulputate porttitor felis, ac suscipit felis dictum id. Fusce iaculis, mauris ac pharetra volutpat, orci lacus tempor leo, sed mattis felis ante at turpis. Sed dapibus lobortis est a sollicitudin. Nam cursus ipsum non tincidunt fermentum. Nulla sagittis sed enim ut ornare. Nam ornare libero ligula, non tincidunt nibh laoreet non. In hendrerit sapien metus, elementum tempor ligula volutpat sed. Vivamus eget varius leo. Sed quis mattis erat, non vulputate augue. Sed egestas rutrum neque, sed commodo nisi euismod in. Quisque dapibus lacus eu nunc congue, ut dapibus risus consectetur. Praesent nec dui et ex porta sagittis eu et justo. Suspendisse rhoncus ipsum eu aliquam eleifend. Fusce lobortis eleifend volutpat. Maecenas vehicula ultrices justo sed rutrum.",
                Author = "Joe Bloggs",
                Posted = DateTime.Now.AddDays(-10)
            },
        };

        [HttpGet(Urls.BlogPosts)]
        public IActionResult GetBlogPosts()
        {
            return Ok(_blogPosts);
        }
    }
}
