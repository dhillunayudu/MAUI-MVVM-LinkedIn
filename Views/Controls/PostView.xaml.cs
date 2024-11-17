using LinkedInClone.Models;

namespace LinkedInClone.Views.Controls;

public partial class PostView : ContentView
{
	public PostView()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty PostDataProperty =
            BindableProperty.Create("PostData", typeof(Post), typeof(PostView), default(Post), BindingMode.TwoWay, propertyChanged: PostDataChanged);

    public Post PostData
    {
        get { return (Post)GetValue(PostDataProperty); }
        set { SetValue(PostDataProperty, value); }
    }

    private static void PostDataChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var itemsLayout = (PostView)bindable;
        //itemsLayout.BuildComponent(newValue as IEnumerable);
    }
}