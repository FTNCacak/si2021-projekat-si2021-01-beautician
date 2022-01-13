using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Interfaces;
using Shared.Models;
namespace BeuticianWeb
{
    public partial class Cart : System.Web.UI.Page
    {
        private readonly ICustomerBusiness customerBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IProductBusiness productBusiness;
        public Cart(ICustomerBusiness customerBusiness, IOrderItemBusiness orderItemBusiness, IOrderBusiness orderBusiness, IProductBusiness productBusiness)
        {

            this.customerBusiness = customerBusiness;
            this.orderItemBusiness = orderItemBusiness;
            this.orderBusiness = orderBusiness;
            this.productBusiness = productBusiness;
        }

        protected void Page_Load(object sender, EventArgs e)
        {


            List<Product> products = Session["Cart"] as List<Product>;

            if (products.Count > 0)
            {
                FillPanel(products, PanelProducts);
                PanelEmpty.Visible = false;


                Panel panelSubmit = new Panel();

                panelSubmit.CssClass = "rowStyle content-center";
                panelSubmit.Style.Add("background", "#fff");

                panelSubmit.ID = "panelSubmit";
               
                panelSubmit.ClientIDMode = ClientIDMode.Static;

                panelSubmit.Style.Add("padding", "0 15px 0 15px");


                Button buttonSubmit = new Button();

                buttonSubmit.CssClass = "btn btn-success btn-lg";
                buttonSubmit.Text = "Potvrdi";

                buttonSubmit.Style.Add("margin-top", "25px");
                buttonSubmit.Style.Add("margin-bottom", "25px");
                buttonSubmit.Style.Add("float", "right");
                buttonSubmit.Click += ButtonSubmit_Click;

                panelSubmit.Controls.Add(buttonSubmit);

                PanelProducts.Controls.Add(panelSubmit);
            }
            else
            {
                PanelEmpty.Visible = true;
            }




        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

            List<Product> products = Session["Cart"] as List<Product>;

            DateTime dateTimeNow = DateTime.Now;

            int CustomerId = (Session["User"] as Customer).CustomerId;


            Order order = new Order(1, CustomerId, dateTimeNow);

            orderBusiness.InsertOrder(order);



            order = orderBusiness.GetSpecificOrder(CustomerId, dateTimeNow);

            foreach (var item in products)
            {
                int ProductId = item.ProductId;

                
                DropDownList drowDownList = PanelProducts.FindControl($"quantity{ProductId}") as DropDownList;

                int Quantity = Convert.ToInt32(drowDownList.SelectedItem.Value);

                OrderItem orderItem = new OrderItem(ProductId, order.OrderId, Quantity);

                Product product = item;

                product.Amount -= Quantity;

                productBusiness.UpdateProduct(product);
                
                orderItemBusiness.InsertOrderItem(orderItem);



            }

            (Session["Cart"] as List<Product>).Clear();

            Response.Redirect("~/SuccessBuy");



        }



        private void FillPanel(List<Product> products, Panel panelToFill)
        {
            if (products != null)
            {

                foreach (Product product in products)
                {
                    Panel panelRow = new Panel();
                    panelRow.ID = $"panelRow{product.ProductId}";
                    panelRow.CssClass = "row rowStyle";


                    Panel panelPicture = new Panel();
                    panelPicture.CssClass = "col col-md-3 col-lg-3 col-sm-12 col-12";
                    panelPicture.Style.Add("text-align", "center");
                    ImageButton imageButton = new ImageButton();

                    imageButton.ImageUrl = $"Images/{product.Image}";
                    imageButton.CssClass = "card-image-top";
                    panelPicture.Controls.Add(imageButton);


                    Panel panelName = new Panel();
                    panelName.CssClass = "col col-md-2 col-lg-2 col-sm-12 col-12 content-center";

                    Label labelName = new Label();

                    labelName.Style.Add("margin-bottom", "25px");
                    labelName.Text = $"{product.Name}";
                    labelName.CssClass = "card-heading";
                    panelName.Controls.Add(labelName);


                    Panel panelPrice = new Panel();
                    panelPrice.CssClass = "col col-md-2 col-lg-2 col-sm-6 col-6 content-center";

                    Label labelPrice = new Label();
                    labelPrice.Text = $"Cena: {product.Price.ToString()} RSD";
                    labelPrice.CssClass = " ";
                    panelPrice.Controls.Add(labelPrice);





                    Panel panelQuantity = new Panel();
                    panelQuantity.CssClass = "col col-md-3 col-lg-2 col-sm-6 col-6 content-center";

                    Label labelQuantity = new Label();
                    labelQuantity.Text = $"Količina: ";
                    labelQuantity.CssClass = " ";

                    panelQuantity.Controls.Add(labelQuantity);

                    panelQuantity.Controls.Add(new Literal { Text = "&nbsp;&nbsp;&nbsp;" });

                    DropDownList dropDownListQuantity = new DropDownList();

                    dropDownListQuantity.ID = $"quantity{product.ProductId}";

                    dropDownListQuantity.ClientIDMode = ClientIDMode.Static;

                    int count;
                    if (product.Amount < 10)
                    {
                        count = product.Amount;
                    }
                    else {
                        count = 10;
                    }

                    for (int i = 1; i <= count; i++)
                    {
                        dropDownListQuantity.Items.Add(new ListItem(i.ToString()));
                    }

                   
                    panelQuantity.Controls.Add(dropDownListQuantity);


                    Panel panelDelete = new Panel();
                    panelDelete.CssClass = "col col-md-2 col-lg-2 col-sm-12 col-12 content-center";

                    Button buttonDelete = new Button();
                    buttonDelete.ID = $"buttonDelete{product.ProductId}";
                    buttonDelete.CssClass = "btn btn-danger";
                    buttonDelete.Text = "Obriši";

                    buttonDelete.Style.Add("margin-top", "25px");
                    buttonDelete.Style.Add("margin-bottom", "25px");

                    buttonDelete.Click += buttonDelete_Click;

                    panelDelete.Controls.Add(buttonDelete);





                    panelRow.Controls.Add(panelPicture);
                    panelRow.Controls.Add(panelName);
                    panelRow.Controls.Add(panelPrice);
                    panelRow.Controls.Add(panelQuantity);
                    panelRow.Controls.Add(panelDelete);






                    panelToFill.Controls.Add(panelRow);

                }

            } // End of if

        } // End of method

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            Button buttonDelete = sender as Button;

            string buttonDeleteID = buttonDelete.ID;

            string removedButtonCartName = buttonDeleteID.Replace("buttonDelete", "");

            int ProductID = Convert.ToInt32(removedButtonCartName);

            Product product = GetProduct(ProductID);

            Control panelToDelete = PanelProducts.FindControl($"panelRow{ProductID}");



            PanelProducts.Controls.Remove(panelToDelete);

            foreach (var item in (Session["Cart"] as List<Product>))
            {
                if (item.ProductId == ProductID)
                {
                    (Session["Cart"] as List<Product>).Remove(item);
                    break;
                }

            }

            if ((Session["Cart"] as List<Product>).Count == 0)
            {
                PanelEmpty.Visible = true;
                Control panelSubmit = PanelProducts.FindControl($"panelSubmit");
                panelSubmit.Visible = false;

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



    }
}