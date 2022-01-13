using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianWeb
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = productBusiness.GetProducts();
            FillPanel(products);
        }

        private readonly ICustomerBusiness customerBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IProductBusiness productBusiness;
        public About(ICustomerBusiness customerBusiness, IOrderItemBusiness orderItemBusiness, IOrderBusiness orderBusiness, IProductBusiness productBusiness)
        {

            this.customerBusiness = customerBusiness;
            this.orderItemBusiness = orderItemBusiness;
            this.orderBusiness = orderBusiness;
            this.productBusiness = productBusiness;
        }



        private void FillPanel(List<Product> products)
        {


            int count = products.Count;

            int numberOfRows = count / 3;

            int temp = 0;
            if (products != null)
            {
                for (int i = 0; i < numberOfRows; i++)
                {
                    temp = 0;
                    Panel panelRow = new Panel();
                    panelRow.CssClass = "row g-5 justify-content-md-center";
                    foreach (Product product in products)
                    {
                        if (temp == 3 && !(i == numberOfRows - 1))
                        {
                            break;
                        }

                        Panel panel = new Panel();
                        panel.CssClass = "card col col-md-4 col-lg-4 col-sm-12 col-12 mb-5";


                        Panel panelInner = new Panel();

                        panelInner.CssClass = "card-body";


                        ImageButton imageButton = new ImageButton();
                        Label labelName = new Label();
                        Label labelPrice = new Label();

                        Label labelDescription = new Label();

                        imageButton.ImageUrl = $"Images/{product.Image}";
                        imageButton.CssClass = "card-image-top";

                        labelName.Text = $"{product.Name}";
                        labelName.CssClass = "card-title card-heading";

                        labelPrice.Text = $"Cena: {product.Price.ToString()} RSD";
                        labelPrice.CssClass = "card-text";

                        labelDescription.Text = product.Description;
                        labelDescription.CssClass = "card-text";

                        panelInner.Controls.Add(imageButton);
                        panelInner.Controls.Add(new Literal { Text = "<br/>" });
                        panelInner.Controls.Add(labelName);
                        panelInner.Controls.Add(new Literal { Text = "<br/>" });
                        panelInner.Controls.Add(labelPrice);
                        panelInner.Controls.Add(new Literal { Text = "<br/>" });
                        panelInner.Controls.Add(labelDescription);
                        panelInner.Controls.Add(new Literal { Text = "<br/>" });

                        if (Session["User"] != null)
                        {

                            if (product.Amount != 0)
                            {


                                Button buttonCart = new Button();

                                buttonCart.CssClass = "btn-cart-style";

                                Panel panelButton = new Panel();

                                panelButton.CssClass = "panel-button";

                                buttonCart.ID = $"buttonCart{product.ProductId}";

                                buttonCart.ClientIDMode = ClientIDMode.Static;

                                buttonCart.Click += buttonCart_Click;

                                panelButton.Controls.Add(buttonCart);

                                panelInner.Controls.Add(panelButton);
                            }

                            else
                            {
                                Label labelNotInStock = new Label();

                                labelNotInStock.Text = "Nema na stanju";

                                Panel panelButton = new Panel();

                                panelButton.CssClass = "panel-button";

                                panelButton.Controls.Add(labelNotInStock);

                                panelInner.Controls.Add(panelButton);

                            }
                        }


                        panel.Controls.Add(panelInner);

                        panelRow.Controls.Add(panel);


                        temp++;
                    }
                    products.RemoveRange(0, temp);
                    PanelProducts.Controls.Add(panelRow);




                } // End of for

            } // End of if

        } // End of method

        protected void buttonCart_Click(object sender, EventArgs e)
        {
            Button buttonCart = sender as Button;

            string buttonCartID = buttonCart.ID;

            string removedButtonCartName = buttonCartID.Replace("buttonCart", "");

            int ProductID = Convert.ToInt32(removedButtonCartName);

            Product product = GetProduct(ProductID);


            if (!IsProductInCart(product, (Session["Cart"] as List<Product>)))
            {
                (Session["Cart"] as List<Product>).Add(product);
            }

        }

        public Product GetProduct(int productID)
        {
            List<Product> products = productBusiness.GetProducts();
            Product product = new Product();
            foreach (var item in products)
            {
                if (item.ProductId == productID)
                {
                    product = item;
                    break;
                }
            }

            return product;
        }

        public bool IsProductInCart(Product product, List<Product> products)
        {
            foreach (var item in products)
            {
                if (product.ProductId == item.ProductId)
                    return true;

            }

            return false;
        }



    }
}