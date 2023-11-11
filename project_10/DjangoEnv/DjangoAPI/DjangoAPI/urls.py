"""
URL configuration for DjangoAPI project.

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/4.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.contrib import admin
from django.urls import path
from WAPI import views

urlpatterns = [
    path('admin/', admin.site.urls),
    path('GetNearest/<int:x>/<int:y>/', views.get_nearest, name='GetNearest')
]
# from django.urls import path, register_converter
# from django.urls.converters import StringConverter

# class FloatConverter(StringConverter):
#     regex = r'[-+]?\d*\.\d+|\d+'  # Regular expression pattern for float values

#     def to_python(self, value):
#         return float(value)  # Convert the captured string to float

# register_converter(FloatConverter, 'float')  # Register the custom converter


# urlpatterns = [
# path('admin/', admin.site.urls),
# path('GetPointByID/<int:id>/',WAPI.views.GetPointByID,name='GetPointByID'),
# ]



