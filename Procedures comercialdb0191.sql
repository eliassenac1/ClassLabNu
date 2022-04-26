-- Procedure comercialdb0191
use comercialdb0191;


-- drop procedure sp_cliente_inserir;
-- drop procedure sp_cliente_alterar;

 -- drop procedure sp_usuarios_inserir;

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- CLIENTES -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

CREATE PROCEDURE sp_cliente_inserir(
_nome varchar(60),
_cpf varchar(11),
_email varchar(60)
)

BEGIN

insert into clientes (nome,cpf,email,datacad,ativo)
values(_nome, _cpf, _email, default, default);
select * from clientes where idcli = (select @@identity);

END
|

delimiter |

create procedure sp_clientes_alterar(
_id int,
_nome varchar(60),
_email varchar(60)
)
begin

update clientes set nome = _nome, email = _email where idcli = _id;

end
|


-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- USUÁRIOS -----------
-- -----------------------------------------------------------------------------------------------------------------------
delimiter |

create procedure sp_usuarios_inserir(
_nome varchar(60),
_email varchar(60),
_senha varchar(32)

)
begin

insert into usuarios (nome, email, senha, ativo)
values (_nome, _email, md5(_senha), default);
select * from usuarios where iduser = (select @@identity);

end
|

delimiter |

create procedure sp_usuarios_alterar(
_iduser int,
_nome varchar(60),
_email varchar(60),
_senha varchar(32),
_nivel varchar(15)
)

begin

update usuarios set nome = _nome, email = _email, senha = md5(_senha), nivel = _nivel where iduser = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- PEDIDOS -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_pedidos_inserir(
_status_ped varchar(15),
_desconto decimal(10,2),
_idcli_ped int,
_iduser_ped int
)

begin

insert into pedidos (data, status_ped, desconto, idcli_ped, iduser_ped)
values (default, _status_ped, _desconto, _idcli, _iduser);
select * from pedidos where	idped = (select @@identity);
end
|

delimiter |

create procedure sp_pedidos_alterar(
_id int,
_status_ped varchar (15),
_desconto decimal (10,2)

)

begin

update pedidos set status_ped = _status_ped, desconto = _desconto where idped = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- PRODUTOS -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_produtos_inserir(
_descricao varchar(60),
_unidade varchar(15),
_codbar char (13),
_valor decimal (10,2),
_desconto decimal (10,2)
)

begin

insert into produtos (descricao, unidade, codbar, valor, desconto)
values(_descricao, _unidade, _codbar, _valor, _desconto);
select * from produtos where idprod = (select @@identity);

end
|

delimiter |

create procedure sp_produtos_alterar(
_id int,
_valor decimal (10,2),
_desconto decimal (10,2)
)

begin

update produtos set valor = _valor, desconto = _desconto where idprod = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- ITEMPEDIDO -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_itempedido_inserir(
_idped_ip int,
_idprod_ip int,
_valor decimal (10,2),
_quantidade decimal (10,2),
_desconto decimal (10,2)
)

begin

insert into intempedido (idped_ip, idprod_ip, valor, quantidade, desconto)
values (_idped, _idprod, _valor, _quantidade, _desconto);


end
|

delimiter |

create procedure sp_itempedido_alterar(
_idped_ip int,
_idprod_ip int,
_valor decimal (10,2),
_quantidade decimal (10,2),
_desconto decimal (10,2)
)

begin

update itempedido set valor = _valor, quantidade = _quantidade, desconto = _desconto where idped = _idped and idprod = _idprod;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- CAIXAS -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_caixas_inserir(
_saldo decimal (10,2),
_status_caixa varchar (32),
_iduser_cx int
)

begin

insert into caixas (data_abertura, saldo, status_caixa, iduser_cx)
values (default, _saldo, _status_caixa, _iduser);
select * from caixas where idcx = (select @@identity);


end
|

delimiter |

create procedure sp_caixas_alterar(
_id int,
_saldo decimal (10,2),
_status_caixa varchar (32),
_iduser_cx int
)

begin

update caixas set saldo = _saldo, status_caixa = _status_caixa where idcx = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- VENDAS -----------
-- -----------------------------------------------------------------------------------------------------------------------
delimiter |

create procedure sp_vendas_inserir(

_status_vnd varchar (15),
_desconto decimal (10,2),
_idcx_vnd int,
_idped_vnd int

)

begin

insert into vendas (data_vnd, status_vnd, desconto, idcx_vnd, idped_vnd)
values (default, _status_vnd, _desconto, _idcx, _idped);
select * from vendas where idvnd = (select @@identity);


end
|

delimiter |

create procedure sp_vendas_alterar(
_id int,
_status_vnd varchar (15),
_desconto decimal (10,2)
)

begin

update vendas set status_vnd = _status_vnd, desconto = _desconto where idvnd = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- PAGAMENTOS -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_pagamentos_inserir(


_valor decimal (10,2),
_idvnd_pag int,
_idtipo int

)

begin

insert into pagamentos (valor, _idvnd_pag, idtipo_pag)
values (_valor, _idvnd, _idtipo);
select * from pagamentos where idpag = (select @@identity);


end
|

delimiter |

create procedure sp_pagamentos_alterar(
_id int,
_valor decimal (10,2)
)

begin

update pagamentos set valor = _valor where idpag = _id;

end
|

-- -----------------------------------------------------------------------------------------------------------------------
						-- ---------- TIPOS -----------
-- -----------------------------------------------------------------------------------------------------------------------

delimiter |

create procedure sp_tipos_inserir(
_nome varchar (20),
_sigla varchar (10)

)

begin

insert into tipos (nome, sigla)
values (_nome, _sigla);
select * from tipos where idtipo = (select @@identity);


end
|

delimiter |

create procedure sp_pagamentos_alterar(
_id int,
_nome varchar (20),
_sigla varchar (10)
)

begin

update tipos set nome = _nome, sigla = _sigla where idtipo = _id;

end
|
