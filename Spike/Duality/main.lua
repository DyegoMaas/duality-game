-----------------------------------------------------------------------------------------
--
-- main.lua
--
-----------------------------------------------------------------------------------------

local grupo = display.newGroup()
grupo.anchorChildren = true
grupo.anchorX = 0
grupo.anchorY = 0
--grupo.anchorX = display.contentWidth / 2
--grupo.anchorY = display.contentWidth / 2
grupo:rotate(0)
--grupo:translate( display.contentCenterX, display.contentCenterY )

--local x, y = display.contentWidth / 2, display.contentWidth / 2
local x, y = 0, -20
local w, h = display.viewableContentWidth, display.viewableContentWidth * 2
local fundo = display.newRect(grupo, x, y, w, h)
fundo:setFillColor(1,1,1,.5)

local function criarCirculo( raio, grupo ) 
	local xCenter = 100
	local yCenter = 0
	local circuloVermelho = display.newCircle( xCenter, yCenter, raio )
	circuloVermelho:setFillColor( 1,0,0,1 )

	if(grupo) then
		grupo:insert(circuloVermelho, false)
	end

	return circuloVermelho
end

local circulo = criarCirculo( 15, grupo )