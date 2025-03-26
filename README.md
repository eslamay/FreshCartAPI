# FreshCart - E-Commerce API

FreshCart is a robust and scalable e-commerce API built with ASP.NET Core. It provides a backend solution for managing products, user wishlists, addresses, shopping carts, orders, and a complete catalog system including categories, subcategories, and brands. The project leverages modern development practices such as Repository Pattern, Entity Framework Core, ASP.NET Core Identity for authentication, and AutoMapper for data transformation.

---

## Features

FreshCart offers a comprehensive set of features to support an e-commerce platform:

### 1. **User Management**
- **Authentication**: Built with ASP.NET Core Identity, allowing secure user registration and login using JWT tokens.
- **Authorization**: Role-based access (e.g., Admin can view all orders, while regular users can only access their own data).

### 2. **Catalog Management (Categories, Subcategories, Brands)**
- **CRUD Operations**: Full Create, Read, Update, and Delete (CRUD) functionality for managing the product catalog:
  - **Categories**: Organize products into main categories (e.g., "Electronics").
    - `POST /api/Categories` - Create a new category.
    - `GET /api/Categories` - Retrieve all categories.
    - `GET /api/Categories/{id}` - Get a specific category.
    - `PUT /api/Categories/{id}` - Update a category.
    - `DELETE /api/Categories/{id}` - Delete a category.
  - **Subcategories**: Nested under categories for finer classification (e.g., "Mobile Phones" under "Electronics").
    - `POST /api/SubCategories` - Create a new subcategory.
    - `GET /api/SubCategories` - Retrieve all subcategories.
    - `GET /api/SubCategories/{id}` - Get a specific subcategory.
    - `PUT /api/SubCategories/{id}` - Update a subcategory.
    - `DELETE /api/SubCategories/{id}` - Delete a subcategory.
  - **Brands**: Associate products with brand identities (e.g., "TechBrand").
    - `POST /api/Brands` - Create a new brand.
    - `GET /api/Brands` - Retrieve all brands.
    - `GET /api/Brands/{id}` - Get a specific brand.
    - `PUT /api/Brands/{id}` - Update a brand.
    - `DELETE /api/Brands/{id}` - Delete a brand.

### 3. **Products**
- **Product Details**: Each product includes attributes such as title, slug, description, price, quantity, images, category, subcategory, brand, ratings, and sales data.
- **Relationships**: Products are linked to `Category`, `SubCategory`, and `Brand` entities for a structured catalog.

### 4. **Wishlist**
- **Add to Wishlist**: Users can add products to their wishlist (POST `/api/Wishlist`).
- **Remove from Wishlist**: Remove a product from the wishlist (DELETE `/api/Wishlist/{productId}`).
- **Get Wishlist**: Retrieve the user's wishlist with full product details, including category, subcategory, and brand (GET `/api/Wishlist`).

### 5. **Addresses**
- **Add Address**: Users can save new shipping addresses (POST `/api/Addresses`).
- **Remove Address**: Delete an existing address (DELETE `/api/Addresses/{addressId}`).
- **Get Specific Address**: Fetch a single address by ID (GET `/api/Addresses/{addressId}`).
- **Get User Addresses**: Retrieve all addresses for the authenticated user (GET `/api/Addresses`).
- **Address Format**: Includes `name`, `details`, `phone`, and `city`.

### 6. **Shopping Cart**
- **Add Product to Cart**: Add a product with a specified quantity (POST `/api/Cart`).
- **Update Quantity**: Adjust the quantity of a product in the cart (PUT `/api/Cart/{cartItemId}`).
- **Get Cart**: Retrieve the user's cart with product details and total price (GET `/api/Cart`).
- **Remove Item**: Delete a specific item from the cart (DELETE `/api/Cart/{cartItemId}`).
- **Clear Cart**: Empty the entire cart (DELETE `/api/Cart/clear`).
- **Cart Logic**: If a product is added multiple times, its quantity increases instead of duplicating the entry.

### 7. **Orders**
- **Create Cash Order**: Convert the cart into a cash-on-delivery order using a selected shipping address (POST `/api/Orders/cash`).
- **Get All Orders**: Admins can retrieve all orders in the system (GET `/api/Orders`).
- **Get User Orders**: Users can view their own order history (GET `/api/Orders/my-orders`).
- **Checkout Session**: Initiate a payment session with a shipping address (POST `/api/Orders/checkout-session`).
- **Order Details**: Includes total price, shipping address, payment method (Cash/Online), status (Pending, Shipped, etc.), and a list of ordered items with product details.

---

## Technology Stack

- **Framework**: ASP.NET Core 8
- **Database**: SQL Server with Entity Framework Core
- **Authentication**: ASP.NET Core Identity with JWT
- **Data Mapping**: AutoMapper
- **Architecture**: Repository Pattern for separation of concerns
- **Validation**: Custom action filters for model validation

---

## Project Structure
FreshCart/
├── Controllers/         # API endpoints for Categories, SubCategories, Brands, Wishlist, Addresses, Cart, and Orders
├── Models/              # Domain models (Product, Wishlist, Address, Cart, Order, etc.)
│   ├── Domain/         # Entity classes
│   └── DTO/            # Data Transfer Objects
├── Data/               # ApplicationDbContext for database configuration
├── Repository/         # Repository interfaces and implementations
├── CustomActionFilters/ # Custom filters (e.g., ValidateModel)
├── Program.cs          # Application entry point and service configuration
└── appsettings.json    # Configuration file (excluded from Git for security)

